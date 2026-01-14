using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Common.UI;
using HarmonyLib;
using Il2CppInterop.Runtime;
using UnityEngine;
using GameData.Profile.SchedulerNodeCollection;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using GameData.Core.Collections;
using System.Linq;
using Il2CppSystem.Runtime.InteropServices.ComTypes;
using GameData.CoreLanguage;

namespace MetaMystia;

[AutoLog]
public partial class PluginManager : MonoBehaviour
{
    public static PluginManager Instance { get; private set; }
    public static readonly string Label = $"{MyPluginInfo.PLUGIN_NAME} v{MyPluginInfo.PLUGIN_VERSION} loaded";
    public static InGameConsole Console { get; private set; }
    private bool isTextVisible = true;
    private readonly ConcurrentQueue<Action> _mainThreadQueue = new ConcurrentQueue<Action>();
    private readonly List<(Action action, Func<bool> condition)> _conditionalActions = new List<(Action, Func<bool>)>();
    public static Scene CurrentGameScene { get; set; } = Scene.MainScene;
    public const bool DEBUG = true;

    public PluginManager(IntPtr ptr) : base(ptr)
    {
        if (Instance != null)
        {
            Log.LogWarning($"Another instance of PluginManager already exists! Destroying this one.");
            Destroy(this);
            return;
        }
        Instance = this;
    }

    internal static GameObject Create(string name)
    {
        var gameObject = new GameObject(name);
        DontDestroyOnLoad(gameObject);

        gameObject.AddComponent(Il2CppType.Of<PluginManager>());

        return gameObject;
    }

    private void Awake()
    {
        Console = new InGameConsole();
        // MpManager.Start();
    }

    private void OnGUI()
    {
        Console?.OnGUI();

        if (isTextVisible)
        {
            var info = new System.Text.StringBuilder();
            info.AppendLine(Label);
            info.AppendLine(MpManager.GetBriefStatus());
            GUI.Label(new Rect(10, Screen.height - 50, 600, 50), info.ToString());
        }
    }

    private void Update()
    {
        while (_mainThreadQueue.TryDequeue(out var action))
        {
            try
            {
                action();
                // Log.LogDebug($"Successfully executed action on main thread");
            }
            catch (Exception e)
            {
                Log.LogError($"Error executing on main thread: {e.Message}\n{e.StackTrace}");
            }
        }

        Console?.Update();

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            Log.LogInfo($"\n");
        }
        if (Input.GetKeyDown(KeyCode.Backslash)) 
        {
            isTextVisible = !isTextVisible;
            Log.LogMessage($"Toggled text visibility: " + isTextVisible);
        }


        if (DEBUG)
        {
            if (Input.GetKeyDown(KeyCode.F9))
            {
                NightGuestManager.CloseIzakayaIfPossible(); 
            }
            if (Input.GetKeyDown(KeyCode.F10))
            {
                NightGuestManager.ModifyWorkTimeLeft(3); 
            }
            if (Input.GetKeyDown(KeyCode.F11))
            {
                Plugin.Debugger??= new Debugger.WebDebugger();
                Plugin.Debugger?.Start();
            }

            if (Input.GetKeyDown(KeyCode.RightBracket) || Input.GetKeyDown(KeyCode.KeypadDivide))
            {
                _ = MpManager.ConnectToPeerAsync("192.168.1.39", 40815); // 这是 SgrYuki 的主机，测试用
            }
            if (Input.GetKeyDown(KeyCode.KeypadMultiply))
            {
                MpManager.Start();
            }
            if (Input.GetKeyDown(KeyCode.KeypadMinus))
            {
                MpManager.Stop();
            }

            if (Input.GetKeyDown(KeyCode.F3))
            {
                // string preNode = "Main_1_BeastForest_008-Event";
                // DataBaseScheduler.allNodes[preNode].postEvents.AddItem(preNode);

                // 注册 trigger 
                var trigger = new SchedulerNode.Trigger();
                trigger.triggerType = SchedulerNode.Trigger.TriggerType.KizunaCheckPoint;
                trigger.triggerId = "_Daiyousei";

                var eventNode = ScriptableObject.CreateInstance<EventNode>();
                eventNode.name = "MetaMystia_Kizuna__Daiyousei_LV1_Upgrade_001_Event";
                eventNode.label = "MetaMystia_Kizuna__Daiyousei_LV1_Upgrade_001_Event";
                eventNode.debugLabel = "大妖精测试";
                eventNode.scheduledEvent = new SchedulerNode.ScheduledEvent()
                {
                    trigger = trigger
                };
                
                eventNode.rewards = new EventNode.Reward[]
                {
                    new EventNode.Reward()
                    {
                        rewardId = "_Daiyousei",
                        rewardType = EventNode.Reward.RewardType.GiveItem,
                        objectType = EventNode.Reward.ObjectType.Recipe,
                        rewardIntArray = new int[] { 11000 }
                    }
                };
                eventNode.missionType = SchedulerNode.SchedulerType.Kitsuna;
                eventNode.postMissionsAfterPerformance.AddItem("MetaMystia_Kizuna__Daiyousei_LV1_Upgrade_002_Mission");
                var _ = DataBaseScheduler.allNodes.TryAdd("MetaMystia_Kizuna__Daiyousei_LV1_Upgrade_001_Event", eventNode);
                Log.Warning($"Added test event node for Daiyousei bond level up. Success: {_}");

                var missionNode = ScriptableObject.CreateInstance<MissionNode>();
                missionNode.name = "MetaMystia_Kizuna__Daiyousei_LV1_Upgrade_002_Mission";
                missionNode.label = "MetaMystia_Kizuna__Daiyousei_LV1_Upgrade_002_Mission";
                missionNode.missionFailedAction = MissionNode.MissionFailedAction.None;
                missionNode.sender = "_Daiyousei";
                missionNode.reciever = "_Daiyousei";
                missionNode.rewards = new MissionNode.Reward[]
                {
                    new MissionNode.Reward()
                    {
                        rewardType = MissionNode.Reward.RewardType.GiveItem,
                        objectType = MissionNode.Reward.ObjectType.Recipe,
                        rewardIntArray = new int[] { 11000 }
                    }
                };
                missionNode.finishCondition = new MissionNode.FinishCondition[]
                {
                    new MissionNode.FinishCondition()
                    {
                        conditionType = MissionNode.FinishCondition.ConditionType.ServeInWork,
                        sellableType = Sellable.SellableType.Food,
                        label = "_Daiyousei",
                        amount = 11000,
                        // product = new Product(
                        //     productType: Product.ProductType.Food,
                        //     productId: 9000,
                        //     productAmount: 1,
                        //     productLabel: "Test Food"
                        // )
                    }
                };
                missionNode.missionType = SchedulerNode.SchedulerType.Kitsuna;

                DataBaseScheduler.allNodes.TryAdd("MetaMystia_Kizuna__Daiyousei_LV1_Upgrade_002_Mission", missionNode);


                Log.Warning($"Adding test event and mission for Daiyousei bond level up.");

                GameData.CoreLanguage.Collections.DataBaseLanguage.Missions.TryAdd(
                    "MetaMystia_Kizuna__Daiyousei_LV1_Upgrade_002_Mission", 
                    new LanguageBase("【title】请大妖精尝尝 TestFood 吧", "【description】请大妖精尝尝 TestFood 吧")
                );
            }
            if (Input.GetKeyDown(KeyCode.F4))
            {
                var scheduledEvents = GameData.RunTime.Common.RunTimeScheduler.scheduledEvents;
                scheduledEvents[-1].Add("MetaMystia_Kizuna__Daiyousei_LV1_Upgrade_001_Event");
                Log.Warning($"Injected event into RunTimeScheduler cache for trigger -1");
            }
            if (Input.GetKeyDown(KeyCode.F5))
            {
                // 强制触发任务 - 成功 -> missionNode 构造测试成功
                GameData.RunTime.Common.RunTimeScheduler.StartMission("_Kizuna_Daiyousei_LV1_Upgrade_001_Mission");
                GameData.RunTime.Common.RunTimeScheduler.StartMission("_Kizuna_Koakuma_LV1_Upgrade_001_Mission");
                GameData.RunTime.Common.RunTimeScheduler.StartMission("_Kizuna_FlandreScarlet_LV1_Upgrade_001_Mission");
                GameData.RunTime.Common.RunTimeScheduler.StartMission("_Kizuna_YagokoroEirin_LV1_Upgrade_001_Mission");
                GameData.RunTime.Common.RunTimeScheduler.StartMission("_Kizuna_Shinki_LV1_Upgrade_001_Mission");
            }
        }
    }

    public void RunOnMainThread(Action action)
    {
        // Log.LogDebug($"Enqueue action to run on main thread");
        _mainThreadQueue.Enqueue(action);
    }

    public void RunOnMainThread(Action action, Func<bool> condition)
    {
        if (condition == null)
        {
            RunOnMainThread(action);
            return;
        }

        lock (_conditionalActions)
        {
            _conditionalActions.Add((action, condition));
        }
    }

    private void FixedUpdate()
    {
        SgrYuki.Utils.CommandScheduler.Tick();
        lock (_conditionalActions)
        {
            for (int i = _conditionalActions.Count - 1; i >= 0; i--)
            {
                var (action, condition) = _conditionalActions[i];
                bool shouldRun = false;
                try
                {
                    shouldRun = condition();
                }
                catch (Exception e)
                {
                    Log.LogError($"Error checking condition: {e.Message}");
                    _conditionalActions.RemoveAt(i);
                    continue;
                }

                if (shouldRun)
                {
                    RunOnMainThread(action);
                    _conditionalActions.RemoveAt(i);
                }
            }
        }

        switch (CurrentGameScene)
        {
            case Scene.DayScene:
                KyoukoManager.OnFixedUpdate();
                break;
            case Scene.WorkScene:
                KyoukoManager.OnFixedUpdate();
                break;
            default:
                break;
        }
    }

    private void OnDestroy()
    {
    }
}
