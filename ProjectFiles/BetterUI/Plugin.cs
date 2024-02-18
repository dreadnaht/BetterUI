using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BetterUI.Patches;
using HarmonyLib;
using UnityEngine;

namespace BetterUI
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.NAME, PluginInfo.VERSION)]
    public class BetterUIBase : BaseUnityPlugin
    {
        internal const string Name = PluginInfo.NAME;
        internal const string GUID = PluginInfo.GUID;
        internal const string Version = PluginInfo.VERSION;

        private readonly Harmony harmony = new Harmony(PluginInfo.GUID);
        private static BetterUIBase Instance;
        private static ManualLogSource mls;

        public void Awake()
        {
            if (Instance == null) Instance = this;

            // LOAD CONFIG
            ConfigCtrl.InitConfig(Config);

            // LOGGER
            CreateCustomLogger();
            Log(Name + ": v" + Version + " HAS AWAKENED FROM A DEEP SLEEP RAWR!");

            // LOAD FPS CONTROLLER
            if (ConfigCtrl.fpsEnabled.Value) harmony.PatchAll(typeof(FpsCtrl));

            // LOAD HUD CONTROLLER
            if (ConfigCtrl.hudEnabled.Value) harmony.PatchAll(typeof(HudCtrl));

            // LOAD CLOCK CONTROLLER
            if (ConfigCtrl.clockEnabled.Value) harmony.PatchAll(typeof(ClockCtrl));

            // LOAD CHAT CONTROLLER
            if (ConfigCtrl.autoFadeChat.Value) harmony.PatchAll(typeof(ChatCtrl));

            // LOAD TIME CONTROLLER
            if (ConfigCtrl.realTimeClock.Value) harmony.PatchAll(typeof(TimeCtrl));
        }

        private void OnGUI()
        {
            // FPS PROCESSOR 
            if (ConfigCtrl.fpsEnabled.Value) FpsCtrl.FpsProcessor();
        }

        private void Update()
        {
            // FPS PROCESSOR RELAY
            if (ConfigCtrl.fpsEnabled.Value) FpsCtrl.FpsProcessorRelay();

            // FRAME RATE OVERRRIDE (INCREASE MAX FRAME RATE - DISBALE VSYNC)
            if (ConfigCtrl.frameRateOverride.Value)
            {
                if (Application.targetFrameRate != 500) Application.targetFrameRate = 500;
                if (QualitySettings.vSyncCount != 0) QualitySettings.vSyncCount = 0;
            }

            // FPS HOTKEY
            if (ConfigCtrl.fpsEnabled.Value)
            {
                KeyboardShortcut fpsVisKey = ConfigCtrl.fpsHotkey.Value;
                if (fpsVisKey.IsDown()) FpsCtrl.state = !FpsCtrl.state;
            }

            // HUD HOTKEY
            if (ConfigCtrl.hudEnabled.Value)
            {
                KeyboardShortcut hudVisKey = ConfigCtrl.hudHotkey.Value;
                if (hudVisKey.IsDown()) HudCtrl.HudToggle();
            }
        }

        private void Start()
        {
            // FRAME RATE OVERRRIDE (INCREASE MAX FRAME RATE - DISBALE VSYNC)
            if (ConfigCtrl.frameRateOverride.Value)
            {
                Application.targetFrameRate = 500;
                QualitySettings.vSyncCount = 0;
            }
        }

        private void CreateCustomLogger()
        {
            try
            {
                mls = BepInEx.Logging.Logger.CreateLogSource(PluginInfo.GUID);
            }
            catch
            {
                mls = base.Logger;
            }
        }

        public static void Log(string message)
        {
            mls.LogMessage(message);
        }
    }
}
