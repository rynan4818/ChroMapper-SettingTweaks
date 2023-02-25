using HarmonyLib;
using System.Reflection;
using UnityEngine;

namespace ChroMapper_SettingTweaks
{
    [Plugin("HitSound ShortTimeChange")]
    public class Plugin
    {
        public static Harmony _harmony;
        public const string HARMONY_ID = "com.github.rynan4818.ChroMapper-SettingTweaks";
        [Init]
        private void Init()
        {
            _harmony = new Harmony(HARMONY_ID);
            _harmony.PatchAll(Assembly.GetExecutingAssembly());
            Debug.Log("HitSound ShortTimeChange Plugin has loaded!");
        }
        [Exit]
        private void Exit()
        {
            _harmony.UnpatchAll(HARMONY_ID);
            Debug.Log("HitSound ShortTimeChangee Plugin has closed!");
        }
    }
}
