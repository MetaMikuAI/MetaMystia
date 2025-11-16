using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using BepInEx.Logging;
using UnityEngine;

namespace MetaMystia;

public static class Utils
{
    private static ManualLogSource Log => Plugin.Instance.Log;

    private static UnityEngine.Rigidbody2D GetPlayerRigidbody2D()
    {
        var characters = UnityEngine.Object.FindObjectsOfType<DayScene.Input.DayScenePlayerInputGenerator>();
        if (characters == null || characters.Length == 0)
        {
            Log.LogMessage("未找到 DayScenePlayerInputGenerator 实例");
            return null;
        }
        if (characters.Length > 1)
        {
            Log.LogWarning($"找到 {characters.Length} 个 DayScenePlayerInputGenerator 实例，使用第一个");
        }

        var character = characters[0];

        var characterUnit = character.Character;
        if (characterUnit == null)
        {
            Log.LogMessage("CharacterControllerUnit 为空");
            return null;
        }

        var rb = characterUnit.rb2d;
        if (rb == null)
        {
            Log.LogMessage("Rigidbody2D 为空");
            return null;
        }

        return rb;
    }

    public static Vector2? GetPlayerPosition()
    {
        var rb = GetPlayerRigidbody2D();
        if (rb == null)
        {
            return null;
        }

        return rb.position;
    }

    public static bool SetPlayerPosition(float x, float y)
    {
        var rb = GetPlayerRigidbody2D();
        if (rb == null)
        {
            return false;
        }

        rb.position = new Vector2(x, y);
        Log.LogMessage($"已设置玩家位置到 ({x}, {y})");
        return true;
    }
};