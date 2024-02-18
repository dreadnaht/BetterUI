using HarmonyLib;

namespace BetterUI.Patches
{
    [HarmonyPatch(typeof(HUDManager))]
    internal static class TimeCtrl
    {
        private static int lTime = -1;

        [HarmonyPostfix]
        [HarmonyPatch(typeof(TimeOfDay))]
        [HarmonyPatch("MoveTimeOfDay")]
        public static void PostfixMoveTimeOfDay(ref TimeOfDay __instance, ref float ___changeHUDTimeInterval)
        {
            int num = (int)(__instance.normalizedTimeOfDay * (60f * (float)__instance.numberOfHours));
            if (num != lTime)
            {
                lTime = num;
                HUDManager.Instance.SetClock(__instance.normalizedTimeOfDay, __instance.numberOfHours);
                ___changeHUDTimeInterval = 0f;
            }
        }
    }
}