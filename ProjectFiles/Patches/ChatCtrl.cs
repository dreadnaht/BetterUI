using HarmonyLib;

namespace BetterUI.Patches
{
    [HarmonyPatch(typeof(HUDManager))]
    internal class ChatCtrl
    {
        [HarmonyPatch("AddChatMessage")]
        [HarmonyPatch("OpenMenu_performed")]
        [HarmonyPatch("SubmitChat_performed")]
        [HarmonyPostfix]
        public static void FadeToNothing(ref HUDManager __instance)
        {
            __instance.PingHUDElement(__instance.Chat, 5f, 1f, 0f);
        }
    }
}