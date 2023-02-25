using ChroMapper_SettingTweaks.Configuration;
using HarmonyLib;

namespace ChroMapper_SettingTweaks.HarmonyPatches
{
    [HarmonyPatch(typeof(DingOnNotePassingGrid), "PlaySound")]
    public class DingOnNotePassingGridPatch
    {
        public static void Prefix(ref float ___thresholdInNoteTime)
        {
            ___thresholdInNoteTime = Options.Instance.thresholdInNoteTime;
        }
    }
}
