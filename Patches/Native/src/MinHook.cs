using System;
using System.Runtime.InteropServices;

namespace MetaMystia;

public class MinHook
{
    public const string DLLFilename = "MinHook.x64.dll";
    // MH_STATUS 枚举
    public enum MH_STATUS
    {
        MH_UNKNOWN = -1,
        MH_OK = 0,
        MH_ERROR_ALREADY_INITIALIZED,
        MH_ERROR_NOT_INITIALIZED,
        MH_ERROR_ALREADY_CREATED,
        MH_ERROR_NOT_CREATED,
        MH_ERROR_ENABLED,
        MH_ERROR_DISABLED,
        MH_ERROR_NOT_EXECUTABLE,
        MH_ERROR_UNSUPPORTED_FUNCTION,
        MH_ERROR_MEMORY_ALLOC,
        MH_ERROR_MEMORY_PROTECT,
        MH_ERROR_MODULE_NOT_FOUND,
        MH_ERROR_FUNCTION_NOT_FOUND
    }

    public IntPtr MH_ALL_HOOKS = IntPtr.Zero;

    // 导入 MinHook 函数
    [DllImport(DLLFilename, CallingConvention = CallingConvention.Cdecl)]
    public static extern MH_STATUS MH_Initialize();

    [DllImport(DLLFilename, CallingConvention = CallingConvention.Cdecl)]
    public static extern MH_STATUS MH_Uninitialize();

    [DllImport(DLLFilename, CallingConvention = CallingConvention.Cdecl)]
    public static extern MH_STATUS MH_CreateHook(IntPtr pTarget, IntPtr pDetour, out IntPtr ppOriginal);

    [DllImport(DLLFilename, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public static extern MH_STATUS MH_CreateHookApi(string pszModule, string pszProcName, IntPtr pDetour, out IntPtr ppOriginal);

    [DllImport(DLLFilename, CallingConvention = CallingConvention.Cdecl)]
    public static extern MH_STATUS MH_RemoveHook(IntPtr pTarget);

    [DllImport(DLLFilename, CallingConvention = CallingConvention.Cdecl)]
    public static extern MH_STATUS MH_EnableHook(IntPtr pTarget);

    [DllImport(DLLFilename, CallingConvention = CallingConvention.Cdecl)]
    public static extern MH_STATUS MH_DisableHook(IntPtr pTarget);

    [DllImport(DLLFilename, CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr MH_StatusToString(MH_STATUS status);


    [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern IntPtr GetModuleHandle(string lpModuleName);

    [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);
}