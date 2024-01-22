# ChroMapper-SettingTweaks

ChroMapperの変更できない設定を変更する、ちょっとしたプラグインです。

This is a little plugin that changes settings that cannot be changed in ChroMapper.

## 設定項目 (Setting items)

### thresholdInNoteTime (Default:0.5)
ChroMapperはヒットサウンドが閾値(0.5拍)未満だと音が変わりますが、その設定値を変更します。
値を0にすると音が変わらなくなります。

ChroMapper changes the sound if the hit sound is less than the threshold value (0.5 beats).
If the value is set to 0, the sound will not change.

### CustomSongsFolder (Default:"")
Custom Levelsフォルダを、全く別のフォルダに変更します。Custom Levelsを第2のWIPフォルダに変更したり、大量にあるCustom Levelsの譜面を読み込ませないようにしたい場合に使用します。
フォルダの`\`は`\\`(￥を￥￥）でエスケープしてください。""の場合は変更しません。

Change the Custom Levels folder to a completely different folder.
Use this if you want to change Custom Levels to a second WIP folder, or if you do not want to load a large number of Custom Levels scores.
Folders `\` should be escaped with `\\`. "" is not changed.

### CustomCMChan (Default:True)
`True`にすると、CM Chan有効時に、ChroMapper設定フォルダの中にある`CustomCMChan`の画像ファイル(PNG,JPEG)を表示リストに追加します。

If set to `True`, image files (PNG, JPEG) of `CustomCMChan` in the ChroMapper settings folder are added to the display list when CM Chan is enabled.

![customCMchan](https://github.com/rynan4818/ChroMapper-SettingTweaks/assets/14249877/6cb68b2b-632c-40b0-b829-2a5f2bdbbb34)

CustomCMChan用画像フォルダ(自動作成されます)

Image folder for CustomCMChan (automatically created)
```
C:\Users\(UserName)\AppData\LocalLow\BinaryElement\ChroMapper\CustomCMChan\
```

### DefaultCMChan (Default:True)
`True`にすると、デフォルトのCM Chan画像も表示します。

If `True`, the default CM Chan image is also displayed.

## 使用方法 (How to use)

プラグインをインストールして起動すると以下のJSONファイルが作成されます。

The following JSON file is created when the plug-in is installed and activated.

```
C:\Users\(UserName)\AppData\LocalLow\BinaryElement\ChroMapper\SettingTweaks.json
```

メモ帳などで開いて直接編集して下さい。

Please open the file with Notepad, etc. and edit it directly.

```
{
  "thresholdInNoteTime" : "0.2",
  "CustomSongsFolder" : "C:\\MappingData\\Beat Saber_Data\\CustomLevels",
  "CustomCMChan" : "True",
  "DefaultCMChan" : "False"
}
```

ChroMapper起動時にしか設定されないので、設定値を変更した場合はChroMapperを再起動してください。

The setting is only set when ChroMapper is started, so restart ChroMapper if you change the setting value.


# 開発者情報 (Developers)
このプロジェクトをビルドするには、ChroMapperのインストールパスを指定する`ChroMapper-SettingTweaks\ChroMapper-SettingTweaks.csproj.user`ファイルを作成する必要があります。

To build this project, you must create a `ChroMapper-SettingTweaks\ChroMapper-SettingTweaks.csproj.user` file that specifies the ChroMapper installation path.

```xml
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="Current" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <ChroMapperDir>C:\TOOL\ChroMapper\chromapper</ChroMapperDir>
  </PropertyGroup>
</Project>
```
