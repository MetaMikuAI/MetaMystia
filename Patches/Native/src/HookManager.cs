using System;
using System.Runtime.InteropServices;

namespace MetaMystia;

public class HookManager
{
    private static bool initialized;

    // 原始函数的指针
    public IntPtr OriginalFunction = IntPtr.Zero;

    // 当前钩子的目标函数地址
    private IntPtr _targetFunction = IntPtr.Zero;

    public void InstallHook(string moduleName, string functionName, Delegate detourFunc)
    {
        // 1. 初始化 MinHook
        var status = MinHook.MH_Initialize();
        if (status != MinHook.MH_STATUS.MH_OK)
        {
            Console.WriteLine($"MH_Initialize failed: {status}");
            return;
        }

        // 2. 获取目标函数的地址
        _targetFunction = MinHook.GetProcAddress(MinHook.GetModuleHandle(moduleName), functionName);
        if (_targetFunction == IntPtr.Zero)
        {
            Console.WriteLine($"Failed to get {functionName} address");
            return;
        }

        // 3. 创建钩子
        var detourPtr = Marshal.GetFunctionPointerForDelegate(detourFunc);
        status = MinHook.MH_CreateHook(_targetFunction, detourPtr, out OriginalFunction);

        if (status != MinHook.MH_STATUS.MH_OK)
        {
            Console.WriteLine($"MH_CreateHook failed: {status}");
            return;
        }

        // 4. 启用钩子
        status = MinHook.MH_EnableHook(_targetFunction);
        if (status != MinHook.MH_STATUS.MH_OK)
        {
            Console.WriteLine($"MH_EnableHook failed: {status}");
            return;
        }

        Console.WriteLine($"{functionName} hook installed successfully");
    }

    public void InstallHookByOffset(
        string moduleName,
        long functionOffset,
        Delegate detourFunc)
    {
        MinHook.MH_STATUS status;
        // 1. 初始化 MinHook
        if (!initialized)
        {
            status = MinHook.MH_Initialize();
            if (status != MinHook.MH_STATUS.MH_OK)
            {
                Console.WriteLine($"MH_Initialize failed: {status}");
                return;
            }
            initialized = true;
        }

        // 2. 获取模块基址（GameAssembly.dll）
        IntPtr moduleBase = MinHook.GetModuleHandle(moduleName);
        if (moduleBase == IntPtr.Zero)
        {
            Console.WriteLine($"Failed to get module base: {moduleName}");
            return;
        }

        // 3. 计算目标函数地址
        _targetFunction = (IntPtr)((long)moduleBase + functionOffset);

        Console.WriteLine(
            $"Hook target at {moduleName}+0x{functionOffset:X} = 0x{_targetFunction:X}"
        );

        // 4. 创建钩子
        var detourPtr = Marshal.GetFunctionPointerForDelegate(detourFunc);
        status = MinHook.MH_CreateHook(
            _targetFunction,
            detourPtr,
            out OriginalFunction
        );

        if (status != MinHook.MH_STATUS.MH_OK)
        {
            Console.WriteLine($"MH_CreateHook failed: {status}");
            return;
        }

        // 5. 启用钩子
        status = MinHook.MH_EnableHook(_targetFunction);
        if (status != MinHook.MH_STATUS.MH_OK)
        {
            Console.WriteLine($"MH_EnableHook failed: {status}");
            return;
        }

        Console.WriteLine(
            $"Hook installed at {moduleName}+0x{functionOffset:X} = 0x{_targetFunction:X}"
        );
    }

    public void InstallHookByAddress(
        IntPtr targetFunction,
        Delegate detourFunc)
    {
        var status = MinHook.MH_Initialize();
        if (status != MinHook.MH_STATUS.MH_OK)
        {
            Console.WriteLine($"MH_Initialize failed: {status}");
            return;
        }

        _targetFunction = targetFunction;

        var detourPtr = Marshal.GetFunctionPointerForDelegate(detourFunc);

        status = MinHook.MH_CreateHook(
            _targetFunction,
            detourPtr,
            out OriginalFunction
        );

        if (status != MinHook.MH_STATUS.MH_OK)
        {
            Console.WriteLine($"MH_CreateHook failed: {status}");
            return;
        }

        status = MinHook.MH_EnableHook(_targetFunction);
        if (status != MinHook.MH_STATUS.MH_OK)
        {
            Console.WriteLine($"MH_EnableHook failed: {status}");
            return;
        }

        Console.WriteLine(
            $"Hook installed at 0x{_targetFunction.ToInt64():X}"
        );
    }

    public void UninstallHook()
    {
        if (_targetFunction == IntPtr.Zero)
        {
            Console.WriteLine("No active hook to uninstall");
            return;
        }

        // 1. 禁用钩子
        var status = MinHook.MH_DisableHook(_targetFunction);
        if (status != MinHook.MH_STATUS.MH_OK)
        {
            Console.WriteLine($"MH_DisableHook failed: {status}");
        }

        // 2. 移除钩子
        status = MinHook.MH_RemoveHook(_targetFunction);
        if (status != MinHook.MH_STATUS.MH_OK)
        {
            Console.WriteLine($"MH_RemoveHook failed: {status}");
        }

        // 3. 卸载 MinHook
        status = MinHook.MH_Uninitialize();
        if (status != MinHook.MH_STATUS.MH_OK)
        {
            Console.WriteLine($"MH_Uninitialize failed: {status}");
        }

        _targetFunction = IntPtr.Zero;
        OriginalFunction = IntPtr.Zero;

        Console.WriteLine("Hook uninstalled successfully");
    }
}

