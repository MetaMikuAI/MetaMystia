using System;
using System.Reflection;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace MetaMystia;

/// <summary>
/// General solution for creating AssetReferences that resolve to custom sprites.
/// Uses ResourceManager.CreateCompletedOperation to build a completed AsyncOperationHandle,
/// then injects it into AssetReference.m_Operation via il2cpp field access.
/// </summary>
[AutoLog]
public static partial class AssetReferenceHelper
{
    private static IntPtr _fieldInfoPtr_m_Operation = IntPtr.Zero;

    /// <summary>
    /// PoC test: validates each step of the injection chain.
    /// Call after il2cpp is fully initialized (e.g. OnFirstEnterMainScene).
    /// </summary>
    public static void TestPoC()
    {
        try
        {
            // ===== Step 1: Create test sprite =====
            Log.LogInfo("[AssetRefHelper] Step 1: Creating test sprite...");
            var tex = new Texture2D(2, 2, TextureFormat.RGBA32, false);
            tex.SetPixel(0, 0, Color.red);
            tex.SetPixel(1, 0, Color.green);
            tex.SetPixel(0, 1, Color.blue);
            tex.SetPixel(1, 1, Color.white);
            tex.Apply();
            tex.hideFlags = HideFlags.HideAndDontSave;
            var sprite = Sprite.Create(tex, new Rect(0, 0, 2, 2), new Vector2(0.5f, 0.5f));
            sprite.name = "PoC_TestSprite";
            sprite.hideFlags = HideFlags.HideAndDontSave;
            Log.LogInfo($"[AssetRefHelper] Step 1 PASS: sprite={sprite.name}, ptr={sprite.Pointer}");

            // ===== Step 2: Get ResourceManager =====
            Log.LogInfo("[AssetRefHelper] Step 2: Getting Addressables.ResourceManager...");
            var rm = Addressables.ResourceManager;
            Log.LogInfo($"[AssetRefHelper] Step 2 PASS: ResourceManager={rm != null}, ptr={rm?.Pointer}");

            // ===== Step 3: CreateCompletedOperation<Sprite> =====
            Log.LogInfo("[AssetRefHelper] Step 3: Calling CreateCompletedOperation<Sprite>...");
            // The typed handle returned from CreateCompletedOperation<Sprite>
            // is a boxed il2cpp value type (AsyncOperationHandle<Sprite>)
            // In interop, it extends Il2CppSystem.ValueType which extends Il2CppSystem.Object
            IntPtr typedHandlePtr = IntPtr.Zero;
            try
            {
                // CreateCompletedOperation<Sprite> returns AsyncOperationHandle<Sprite>
                // which in il2cpp interop is a class wrapping a boxed struct
                var typedHandle = rm.CreateCompletedOperation<Sprite>(sprite, (string)null);
                typedHandlePtr = typedHandle.Pointer;
                Log.LogInfo($"[AssetRefHelper] Step 3 PASS: typedHandle ptr={typedHandlePtr}");
            }
            catch (Exception ex)
            {
                Log.LogError($"[AssetRefHelper] Step 3 FAIL: {ex.GetType().Name}: {ex.Message}");
                Log.LogError($"[AssetRefHelper] Step 3 StackTrace: {ex.StackTrace}");
                return;
            }

            // ===== Step 4: Extract IAsyncOperation from typed handle =====
            Log.LogInfo("[AssetRefHelper] Step 4: Extracting internal op from typed handle...");
            // Try to read m_InternalOp from the typed handle
            // AsyncOperationHandle<T> should have the same layout as AsyncOperationHandle
            // Both store: IAsyncOperation + int version + string locationName
            IAsyncOperation internalOp = null;
            int version = 0;
            try
            {
                // Method 1: Try to get the non-generic handle from the typed one
                // The typed handle in il2cpp interop wraps the boxed struct
                // Unbox to get raw bytes, then construct non-generic handle
                IntPtr unboxed = IL2CPP.il2cpp_object_unbox(typedHandlePtr);
                Log.LogInfo($"[AssetRefHelper] Step 4: unboxed ptr={unboxed}");

                // Read the IAsyncOperation pointer at offset 0
                IntPtr internalOpPtr = System.Runtime.InteropServices.Marshal.ReadIntPtr(unboxed, 0);
                // Read version at offset 8 (IntPtr size on x64)
                version = System.Runtime.InteropServices.Marshal.ReadInt32(unboxed, IntPtr.Size);
                Log.LogInfo($"[AssetRefHelper] Step 4: internalOpPtr={internalOpPtr}, version={version}");

                // Construct a non-generic AsyncOperationHandle with the same internals
                // Use the constructor: .ctor(IAsyncOperation op, int version)
                if (internalOpPtr != IntPtr.Zero)
                {
                    internalOp = new IAsyncOperation(internalOpPtr);
                    Log.LogInfo($"[AssetRefHelper] Step 4 PASS: internalOp valid");
                }
                else
                {
                    Log.LogError("[AssetRefHelper] Step 4 FAIL: internalOp ptr is zero");
                    return;
                }
            }
            catch (Exception ex)
            {
                Log.LogError($"[AssetRefHelper] Step 4 FAIL: {ex.GetType().Name}: {ex.Message}");
                return;
            }

            // ===== Step 5: Create non-generic AsyncOperationHandle =====
            Log.LogInfo("[AssetRefHelper] Step 5: Creating non-generic AsyncOperationHandle...");
            AsyncOperationHandle nonGenericHandle = null;
            try
            {
                nonGenericHandle = new AsyncOperationHandle(internalOp, version);
                bool handleValid = nonGenericHandle.IsValid();
                bool handleDone = nonGenericHandle.IsDone;
                var handleResult = nonGenericHandle.Result;
                Log.LogInfo($"[AssetRefHelper] Step 5: IsValid={handleValid}, IsDone={handleDone}, Result={handleResult?.ToString() ?? "null"}");

                if (handleResult != null)
                {
                    var resultSprite = handleResult.TryCast<Sprite>();
                    Log.LogInfo($"[AssetRefHelper] Step 5 PASS: Result cast to Sprite={resultSprite?.name ?? "null"}, match={resultSprite?.Pointer == sprite.Pointer}");
                }
                else
                {
                    Log.LogWarning("[AssetRefHelper] Step 5: Result is null (handle may not be truly completed)");
                }
            }
            catch (Exception ex)
            {
                Log.LogError($"[AssetRefHelper] Step 5 FAIL: {ex.GetType().Name}: {ex.Message}");
                return;
            }

            // ===== Step 6: Create AssetReferenceSprite and inject m_Operation =====
            Log.LogInfo("[AssetRefHelper] Step 6: Creating AssetReferenceSprite and injecting m_Operation...");
            try
            {
                var assetRef = new AssetReferenceSprite("test-metamystia-custom-guid");
                Log.LogInfo($"[AssetRefHelper] Step 6: Before injection - IsValid={assetRef.IsValid()}, RuntimeKeyIsValid={assetRef.RuntimeKeyIsValid()}");

                InjectMOperation(assetRef, typedHandlePtr);

                bool afterValid = assetRef.IsValid();
                Log.LogInfo($"[AssetRefHelper] Step 6: After injection - IsValid={afterValid}");

                if (afterValid)
                {
                    var asset = assetRef.Asset;
                    Log.LogInfo($"[AssetRefHelper] Step 6: Asset={asset?.name ?? "null"}");
                    var assetSprite = asset?.TryCast<Sprite>();
                    Log.LogInfo($"[AssetRefHelper] Step 6 PASS: Sprite={assetSprite?.name ?? "null"}, match={assetSprite?.Pointer == sprite.Pointer}");
                }
                else
                {
                    Log.LogError("[AssetRefHelper] Step 6 FAIL: IsValid still false after injection");
                }
            }
            catch (Exception ex)
            {
                Log.LogError($"[AssetRefHelper] Step 6 FAIL: {ex.GetType().Name}: {ex.Message}");
            }

            Log.LogInfo("[AssetRefHelper] PoC test complete.");
        }
        catch (Exception ex)
        {
            Log.LogError($"[AssetRefHelper] PoC FATAL: {ex}");
        }
    }

    /// <summary>
    /// Inject a completed AsyncOperationHandle into AssetReference.m_Operation
    /// using il2cpp raw field access.
    /// </summary>
    private static unsafe void InjectMOperation(AssetReference assetRef, IntPtr boxedHandlePtr)
    {
        if (_fieldInfoPtr_m_Operation == IntPtr.Zero)
        {
            var fieldPtrField = typeof(AssetReference).GetField(
                "NativeFieldInfoPtr_m_Operation",
                BindingFlags.NonPublic | BindingFlags.Static);

            if (fieldPtrField == null)
                throw new InvalidOperationException("Could not find NativeFieldInfoPtr_m_Operation field");

            _fieldInfoPtr_m_Operation = (IntPtr)fieldPtrField.GetValue(null);
            Log.LogInfo($"[AssetRefHelper] Cached m_Operation FieldInfoPtr: {_fieldInfoPtr_m_Operation}");
        }

        // Unbox the handle to get raw struct bytes
        IntPtr unboxedPtr = IL2CPP.il2cpp_object_unbox(boxedHandlePtr);

        // Write the struct bytes to assetRef.m_Operation
        IL2CPP.il2cpp_field_set_value(
            IL2CPP.Il2CppObjectBaseToPtrNotNull(assetRef),
            _fieldInfoPtr_m_Operation,
            (void*)unboxedPtr
        );
    }

    /// <summary>
    /// Registry mapping custom GUID keys to Sprites.
    /// Populated by CreateForSprite; queried by consumers that use direct .Asset access.
    /// </summary>
    internal static readonly System.Collections.Generic.Dictionary<string, Sprite> SpriteRegistry = new();

    /// <summary>
    /// Registry mapping DialogAction IL2CPP pointers to Sprites.
    /// Used by Run() patch for CG actions that bypass the Addressables loading pipeline.
    /// </summary>
    internal static readonly System.Collections.Generic.Dictionary<IntPtr, Sprite> CGSpriteRegistry = new();

    /// <summary>
    /// Register a CG sprite for a specific DialogAction, for the Run() patch to handle.
    /// </summary>
    internal static void RegisterCGSprite(IntPtr actionPointer, Sprite sprite)
        => CGSpriteRegistry[actionPointer] = sprite;

    /// <summary>
    /// Try to get a registered CG sprite for a DialogAction pointer.
    /// </summary>
    internal static bool TryGetCGSprite(IntPtr actionPointer, out Sprite sprite)
        => CGSpriteRegistry.TryGetValue(actionPointer, out sprite);

    /// <summary>
    /// Look up a registered custom sprite by its GUID key.
    /// </summary>
    internal static bool TryGetRegisteredSprite(string key, out Sprite sprite)
        => SpriteRegistry.TryGetValue(key, out sprite);

    /// <summary>
    /// General-purpose method: create an AssetReferenceSprite that resolves to a custom Sprite.
    ///
    /// NOTE: The game's LoadAssetAsync treats an already-valid m_Operation as an error,
    /// so m_Operation injection only works for direct .Asset access.
    /// For pipelines that call LoadAssetAsync (e.g. dialog CG loading),
    /// consumers should use TryGetRegisteredSprite + the Run() patch instead.
    /// </summary>
    public static AssetReferenceSprite CreateForSprite(Sprite sprite, string customKey = null)
    {
        customKey ??= $"metamystia_{Guid.NewGuid():N}";

        // Register in sprite lookup table (used by Run() patch for LoadAssetAsync paths)
        SpriteRegistry[customKey] = sprite;

        var assetRef = new AssetReferenceSprite(customKey);

        // Also inject m_Operation for direct .Asset access paths
        var rm = Addressables.ResourceManager;
        var typedHandle = rm.CreateCompletedOperation<Sprite>(sprite, (string)null);
        InjectMOperation(assetRef, typedHandle.Pointer);

        return assetRef;
    }
}
