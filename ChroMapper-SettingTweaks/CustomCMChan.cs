using ChroMapper_SettingTweaks.Configuration;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace ChroMapper_SettingTweaks
{
    public class CustomCMChan
    {
        public readonly string CustomCMChanDirectory = "CustomCMChan";
        public readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPEG", ".PNG" };
        public List<string> cmChanList = new List<string>();
        public void LoadCustomCMChan()
        {
            if (Options.Instance.CustomCMChan)
            {
                Debug.Log("Custom CM Chan Enabled");
                var CMChanDir = Path.Combine(Application.persistentDataPath, CustomCMChanDirectory);
                if (!Directory.Exists(CMChanDir))
                    Directory.CreateDirectory(CMChanDir);
                if (Directory.Exists(CMChanDir))
                {
                    var allFiles = Directory.GetFiles(CMChanDir, "*.*", SearchOption.AllDirectories);
                    foreach (var file in allFiles)
                    {
                        if (ImageExtensions.Contains(Path.GetExtension(file).ToUpperInvariant()))
                            cmChanList.Add(file);
                    }
                    var localization = Traverse.Create(PersistentUI.Instance).Field("localization").GetValue<Localization>();
                    if (Options.Instance.DefaultCMChan || cmChanList.Count == 0)
                        Array.Resize(ref localization.WaifuSprites, localization.WaifuSprites.Length + cmChanList.Count);
                    else
                        localization.WaifuSprites = new Sprite[cmChanList.Count];
                    for (var i = 0; i < cmChanList.Count; i++)
                    {
                        var bytes = File.ReadAllBytes(cmChanList[i]);
                        var texture = new Texture2D(2, 2);
                        texture.LoadImage(bytes);
                        var sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0, 0), 100.0f);
                        sprite.name = Path.GetFileNameWithoutExtension(cmChanList[i]);
                        localization.WaifuSprites[localization.WaifuSprites.Length - cmChanList.Count + i] = sprite;
                    }
                }
            }
        }
    }
}
