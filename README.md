# ChroMapper-HitSoundShortTimeChange

ChroMapperはヒットサウンドが閾値(0.5秒)未満だと音が変わりますが、その設定値を変更するパッチです。

プラグインをインストールして起動すると
```
C:\Users\ユーザー名\AppData\LocalLow\BinaryElement\ChroMapper\HitSoundShortTimeChange.json
```
が作成されるので、メモ帳などで開いて
```
{
  "thresholdInNoteTime" : "0.2"
}
```
thresholdInNoteTimeの値を変更します。0にすると音が変わらなくなります。

# 開発者情報 (Developers)
このプロジェクトをビルドするには、ChroMapperのインストールパスを指定する`ChroMapper-RhythmMarker\ChroMapper-RhythmMarker.csproj.user`ファイルを作成する必要があります。

To build this project, you must create a `ChroMapper-RhythmMarker\ChroMapper-RhythmMarker.csproj.user` file that specifies the ChroMapper installation path.

```xml
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="Current" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <ChroMapperDir>C:\TOOL\ChroMapper\chromapper</ChroMapperDir>
  </PropertyGroup>
</Project>
```
