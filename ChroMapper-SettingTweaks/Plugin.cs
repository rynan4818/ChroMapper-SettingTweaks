using HarmonyLib;
using System.Reflection;
using UnityEngine;

namespace ChroMapper_SettingTweaks
{
    [Plugin("Setting Tweaks")]
    public class Plugin
    {
        public static Harmony _harmony;
        public const string HARMONY_ID = "com.github.rynan4818.ChroMapper-SettingTweaks";
        [Init]
        private void Init()
        {
            _harmony = new Harmony(HARMONY_ID);
            _harmony.PatchAll(Assembly.GetExecutingAssembly());
            new CustomCMChan().LoadCustomCMChan();
            Debug.Log("Setting Tweaks Plugin has loaded!");
        }
        [Exit]
        private void Exit()
        {
            _harmony.UnpatchAll(HARMONY_ID);
            Debug.Log("Setting Tweaks Plugin has closed!");
        }
    }
}
