using ChroMapper_HitSoundShortTimeChange.Configuration;
using HarmonyLib;
using System.IO;

namespace ChroMapper_HitSoundShortTimeChange.HarmonyPatches
{
    [HarmonyPatch(typeof(Settings), "CustomSongsFolder", MethodType.Getter)]
    public class SettingsPatch
    {
        public static void Postfix(ref string __result)
        {
            if (Directory.Exists(Options.Instance.CustomSongsFolder))
                __result = Options.Instance.CustomSongsFolder;
        }
    }
}
