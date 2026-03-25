
using System;
using UnityEngine;

using Common.CharacterUtility;

namespace MetaMystia;

/// <summary>
/// 玩家基类，包含本地玩家和远程对端玩家的公共状态和方法
/// </summary>
[AutoLog]
public abstract partial class NetPlayer
{
    #region 玩家标识
    /// <summary>
    /// 玩家自定义 ID（显示名）
    /// </summary>
    public string Id { get; set; } = "";

    /// <summary>
    /// 玩家的唯一标识符（主机=0，客机=1,2,3...），由主机在 HelloAck 中分配
    /// </summary>
    public int Uid { get; set; } = -1;

    #endregion


    #region Unity角色组件便捷访问
    /// <summary>
    /// 获取玩家角色的 CharacterControllerUnit 实例
    /// </summary>
    public abstract CharacterControllerUnit GetCharacterUnit();

    public CharacterControllerUnit unit => GetCharacterUnit();
    public Rigidbody2D rb2d => unit?.rb2d;
    public Collider2D cl2d => unit?.cl2d;
    #endregion


    /// <summary>
    /// 玩家的资源数据库，记录该玩家拥有的 DLC / Mod 资源 ID
    /// </summary>
    public ResourceDataBase DataBase { get; set; } = new();


    #region 角色状态
    /// <summary>
    /// 当前所在地图标签(主要用于 `DayScene`)
    /// </summary>
    public string MapLabel { get; set; } = "";

    /// <summary>
    /// 是否已经结束白天
    /// </summary>
    public bool IsDayOver { get; set; } = false;

    /// <summary>
    /// 是否已经结束准备
    /// </summary>
    public bool IsPrepOver { get; set; } = false;

    /// <summary>
    /// 选择的居酒屋地图标签（选店阶段）
    /// </summary>
    public string IzakayaMapLabel { get; set; } = "";

    /// <summary>
    /// 选择的居酒屋等级（选店阶段）
    /// </summary>
    public int IzakayaLevel { get; set; } = 0;

    /// <summary>
    /// 是否正在奔跑
    /// </summary>
    public bool IsSprinting { get; set; } = false;

    /// <summary>
    /// 角色移动速度
    /// </summary>
    public virtual float Speed { get; set; } = 1f;

    /// <summary>
    /// 皮肤
    /// </summary>
    public PlayerSkin Skin { get; set; } = new();

    public void UpdateCharacterSprite() => Skin?.ApplyToUnit(unit);

    /// <summary>
    /// 输入方向向量
    /// </summary>
    public Vector2 InputDirection { get; set; } = Vector2.zero;

    /// <summary>
    /// 玩家角色当前位置
    /// NOTE: 不要使用 `?.` 运算符检查 IL2Cpp Unity 对象，它只检查 C# null，
    ///       无法检测已销毁的 Unity 原生对象。使用 `== null` 以走 Unity 重载运算符。
    /// </summary>
    public Vector2 Position
    {
        get
        {
            var r = rb2d;
            if (r == null) return Vector2.zero;
            var t = r.transform;
            if (t == null) return Vector2.zero;
            return (Vector2)t.position;
        }
    }
    #endregion

    /// <summary>
    /// 设置角色的 Z 轴位置（用于控制渲染层级）
    /// </summary>
    /// <param name="z"></param>
    public void SetZ(int z)
    {
        var pos = rb2d.transform.position;
        rb2d.transform.position = new Vector3(pos.x, pos.y, z);
    }

    /// <summary>
    /// 重置同步状态标志（DayOver、PrepOver、IzakayaSelection 等）
    /// </summary>
    public virtual void ResetState()
    {
        MapLabel = "";
        IsDayOver = false;
        IsPrepOver = false;
        IzakayaMapLabel = "";
        IzakayaLevel = 0;
    }

    /// <summary>
    /// 重置运动相关状态
    /// </summary>
    public virtual void ResetMotion()
    {
        IsSprinting = false;
        InputDirection = Vector2.zero;
    }
}
