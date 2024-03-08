using BepInEx.Configuration;
using UnityEngine;

namespace BetterUI
{
    internal static class ConfigCtrl
    {
        // HUD
        internal static ConfigEntry<bool> hudEnabled;
        internal static ConfigEntry<KeyboardShortcut> hudHotkey;
        // FPS
        internal static ConfigEntry<bool> fpsEnabled;
        internal static ConfigEntry<KeyboardShortcut> fpsHotkey;
        internal static ConfigEntry<int> fpsSize;
        internal static ConfigEntry<string> fpsColorStr;
        internal static Color fpsColor;
        // CLOCK
        internal static ConfigEntry<bool> clockEnabled;
        internal static ConfigEntry<KeyboardShortcut> clockHotkey;
        internal static ConfigEntry<float> clockInsideShipVis;
        internal static ConfigEntry<float> clockInsideFacilityVis;
        internal static ConfigEntry<bool> realTimeClock;
        // CHAT
        internal static ConfigEntry<bool> autoFadeChat;
        // EXPERIMENTAL
        internal static ConfigEntry<bool> frameRateOverride;

        public static void InitConfig(ConfigFile config)
        {
            // HUD
            hudEnabled = config.Bind("1_HUD", "Enable_HUD", true, "Enable the HUD Hotkey");
            hudHotkey = config.Bind("1_HUD", "HUD_Hotkey", new KeyboardShortcut(KeyCode.Keypad7), "Hotkey to toggle the visibility of the HUD");
            // FPS
            fpsEnabled = config.Bind("2_FPS", "Enable_FPS", true, "Enable the FPS Hotkey");
            fpsHotkey = config.Bind("2_FPS", "FPS_Hotkey", new KeyboardShortcut(KeyCode.Keypad8), "Hotkey to toggle the visibility of the FPS counter (hidden by default)");
            fpsSize = config.Bind("2_FPS", "FPS_Font_Size", 13, "Change the FPS font size");
            fpsColorStr = config.Bind("2_FPS", "FPS_Font_Color", "#FFFFFF", "Change the FPS font color (HEX Code)");
            ColorUtility.TryParseHtmlString(fpsColorStr.Value, out fpsColor);
            // CLOCK
            clockEnabled = config.Bind("3_Clock", "Enable_Clock", true, "Enable the Clock Hotkey");
            clockHotkey = config.Bind("3_Clock", "Clock_Hotkey", new KeyboardShortcut(KeyCode.Keypad9), "Hotkey to toggle the visibility of the clock when you're inside the ship or a building (hidden by default)");
            clockInsideShipVis = config.Bind("3_Clock", "Clock_Inside_Ship_Visibility", 0.3f, "Visibility of the clock when inside the ship");
            clockInsideFacilityVis = config.Bind("3_Clock", "Clock_Inside_Facility_Visibility", 0.3f, "Visibility of the clock when inside a building");
            realTimeClock = config.Bind("3_Clock", "Real_Time_Clock", false, "Smooth the speed of time on the clock (appearance only)");
            // CHAT
            autoFadeChat = config.Bind("4_CHAT", "Auto_Fade_Chat", true, "Hides the chat box when not being used");
            // EXPERIMENTAL
            frameRateOverride = config.Bind("5_EXPERIMENTAL", "Frame_Rate_Override", false, "Set target frame rate to 500 and turn off vSync");
        }
    }

    public static class PluginInfo
    {
        public const string GUID = "LessonLethal.BetterUI";
        public const string AUTHOR = "LessonLethal";
        public const string NAME = "BetterUI";
        public const string VERSION = "1.1.0";
    }
}