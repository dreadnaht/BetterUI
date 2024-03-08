using BepInEx.Configuration;
using BetterUI;
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
                // ONLY CHECK IF PLAYER IN SHIP
                if (playerControllerB.isInHangarShipRoom)
                {
                    __instance.Clock.targetAlpha = (state) ? ConfigCtrl.clockInsideShipVis.Value : 0f;
                    return false;
                }
                // ONLY CHECK IF PLAYER IS IN FACILITY
                if (playerControllerB.isInsideFactory)
                {
	                __instance.Clock.targetAlpha = (state) ? ConfigCtrl.clockInsideFacilityVis.Value : 0f;
	                return false;
                }
    		}
    		return true;
    	}
    }
}