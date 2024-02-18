using UnityEngine;

namespace BetterUI.Patches
{
    internal static class FpsCtrl
    {
        public static bool state = false;
        public static float dTime;

        public static void FpsProcessor()
        {
            Mathf.RoundToInt(1f / dTime);
            int num = Mathf.RoundToInt(1f / Time.deltaTime);
            if (state) DrawFPS("{0}", num);
        }

        public static void FpsProcessorRelay()
        {
            dTime += (Time.unscaledDeltaTime - dTime) * 0.1f;
        }

        public static void DrawFPS(string format, params object[] args)
        {
            string text = string.Format(format, args);
            GUIStyle gUIStyle = new(GUI.skin.label);
            gUIStyle.fontSize = ConfigCtrl.fpsSize.Value;
            gUIStyle.normal.textColor = ConfigCtrl.fpsColor;
            gUIStyle.fontStyle = FontStyle.Normal;
            GUI.Label(new Rect(Screen.width - 30f, 5f, 30f, 30f), new GUIContent(text), gUIStyle);
        }
    }
}