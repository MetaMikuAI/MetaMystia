using BepInEx.Logging;
using UnityEngine;
using UnityEngine.UI;
using System;
using Il2CppInterop.Runtime;

namespace MetaMystia;
public class PluginManager : MonoBehaviour
{
    public static PluginManager Instance { get; private set; }
    public static ManualLogSource Log => Plugin.Instance.Log;

    private bool isTextVisible = true;

    public PluginManager(IntPtr ptr) : base(ptr)
    {
        Instance = this;
    }

    internal static GameObject Create(string name)
    {
        var gameObject = new GameObject(name);
        DontDestroyOnLoad(gameObject);

        var component = new PluginManager(gameObject.AddComponent(Il2CppType.Of<PluginManager>()).Pointer);

        return gameObject;
    }

    private void Awake()
    {
        
    }

    private void OnGUI()
    {
        if (isTextVisible)
        {
            GUI.Label(new Rect(10, Screen.height - 50, 300, 50), "MetaMystia loaded");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift)) {
            Log.LogMessage("hello world from MetaMystia");
        }

        if (Input.GetKeyDown(KeyCode.Backslash)) {
            isTextVisible = !isTextVisible;
            Log.LogMessage("Toggled text visibility: " + isTextVisible);
        }
    }
}
