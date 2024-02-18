using BepInEx.Configuration;
using GameNetcodeStuff;
using HarmonyLib;
using UnityEngine;

namespace BetterUI.Patches
{
    [HarmonyPatch(typeof(HUDManager))]
    internal static class ClockCtrl
    {
        private static bool state = false;

        [HarmonyPrefix]
    	[HarmonyPatch("SetClockVisible")]
    	public static bool PrefixVisible(ref HUDManager __instance)
    	{
            // CLOCK HOTKEY
            KeyboardShortcut clockVisKey = ConfigCtrl.clockHotkey.Value;
            if (clockVisKey.IsDown()) state = !state;
            // CLOCK VISIBILITY MANAGER
            GameNetworkManager instance = GameNetworkManager.Instance;
    		PlayerControllerB playerControllerB = null;
    		if (instance != null) playerControllerB = instance.localPlayerController;
            if ((Object)(object)playerControllerB != null)
            {
                // ONLY CHECK IF PLAYER IN SHIP OR INSIDE BUILDING
                if (playerControllerB.isInHangarShipRoom || playerControllerB.isInsideFactory)
                {
                    __instance.Clock.targetAlpha = (state) ? ConfigCtrl.clockInsideVis.Value : 0f;
                    return false;
                }
    		}
    		return true;
    	}
    }
}