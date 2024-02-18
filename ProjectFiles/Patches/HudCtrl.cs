namespace BetterUI.Patches
{
    internal class HudCtrl
    {
        private static bool state = false;

        public static void HudToggle()
        {
            state = !state;
            HUDManager.Instance.HideHUD(state);
        }
    }
}