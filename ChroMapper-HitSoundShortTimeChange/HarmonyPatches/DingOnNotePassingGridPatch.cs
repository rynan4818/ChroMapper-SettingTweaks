using ChroMapper_HitSoundShortTimeChange.Configuration;
using HarmonyLib;

namespace ChroMapper_HitSoundShortTimeChange.HarmonyPatches
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
