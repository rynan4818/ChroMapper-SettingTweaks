using ChroMapper_SettingTweaks.Configuration;
using HarmonyLib;
using System.IO;

namespace ChroMapper_SettingTweaks.HarmonyPatches
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
