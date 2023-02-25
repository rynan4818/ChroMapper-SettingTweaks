# ChroMapper-SettingTweaks

ChroMapperの変更できない設定を変更する、ちょっとしたプラグインです。

## 設定項目

### thresholdInNoteTime
ChroMapperはヒットサウンドが閾値(0.5拍)未満だと音が変わりますが、その設定値を変更します。
値を0にすると音が変わらなくなります。

### CustomSongsFolder
Custom Levelsフォルダを、全く別のフォルダに変更します。フォルダの\は\\(￥を￥￥）でエスケープしてください。

## 使い方

プラグインをインストールして起動すると
```
C:\Users\ユーザー名\AppData\LocalLow\BinaryElement\ChroMapper\SettingTweaks.json
```
が作成されるので、メモ帳などで開いて
```
{
  "thresholdInNoteTime" : "0.2",
  "CustomSongsFolder" : "C:\\MappingData\\Beat Saber_Data\\CustomLevels"
}
```

ChroMapper起動時にしか設定されないので、設定値を変更した場合はChroMapperを再起動してください。

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
