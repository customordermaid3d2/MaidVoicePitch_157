﻿# 声の音程を変えるUnityInjector用プラグイン

## 「カスタムメイド3D2攻略wiki」から来た方へ

[導入の説明](../INSTALL.md)を読んでください。このページに、あなたの欲しいものはありません


## 概要

※ 動作には「拡張セーブデータパッチ CM3D2.ExternalSaveData.Patcher」が必要です ※

声の音程やスライダーの拡張などを行います


## コンパイル方法

[config.batの設定](../INSTALL.md)を行った後、このディレクトリの compile.bat を実行することでコンパイルができます


## 動作確認と操作方法

 - コンパイル後 C:\KISS\CM3D2_KAIZOU\CM3D2x64.exe を起動して、動作を確認してください
 - 「F4」キーを押すと、フリーコメント欄の内容が反映されます。記述方法は従来どおりです
 - CM3D2.AddModsSlider.Plugin と併用するのを推奨します


## データの仕様

 - [拡張セーブデータに追加されるデータ](exsave_format.md)
 - [SLIDER_TEMPLATEで指定するXMLファイルの書式](SLIDER_TEMPLATE_format.md)
 - [FACE_SCRIPT_TEMPLATEで指定するXMLファイルの書式](FACE_SCRIPT_TEMPLATE_format.md)


## 履歴
 - 0.2.17.4
     - 公式ver1.32対応
 - 0.2.17.3
     - 公式ver1.26対応
 - 0.2.17.2
     - 0.2.17.1で拡張スライダーを動かすとエラーが出ていたのを修正
 - 0.2.17.1
     - ポールダンスで腰の長さのがカスタムと異なる問題を対処
     - オブジェクト名が「body001」以外のボディを使用した場合に、拡張スライダーの「胴(肋骨から上)スケーリング」の設定が、顔等にも影響していたのを修正
     - 「全身」「足の長さ」が拡張域に設定されている場合に、腰の長さが正しく設定されない問題を修正
     　※「全身」「足の長さ」が拡張域に設定されていて、拡張スライダーの「胴(肋骨)ポジション」を開いたことがないメイドの見た目に影響があります。
 - 0.2.17.0
   - GPフェイス対応。
 - 0.2.16.1
   - 公式ｖ1.23(1.22?)対応。それ以前のバージョンでは動作しません。
 - 0.2.16.0
   - 「背骨の位置」の名称を「胴(下腹部)ポジション」の変更、表示位置も変更
   - 「胴(腹部)ポジション」、「胴(みぞおち)ポジション」、「胴(肋骨)ポジション」、「首ポジション」、「鎖骨スケーリング」を追加
      ※「胴(肋骨)ポジション」について、既存の処理では「身長」・「足の長さ」の拡張分が反映されなくなっていました。
      ※「胴(肋骨)ポジション」の追加に伴い、拡張分も反映されるようになるが、既存のキャラに影響を及ぼさないように
      ※「胴(肋骨)ポジション」の拡張項目を開くまでは今まで通りとし、項目を開いたときから反映されます。
      ※（身長・足の長さが拡張範囲にある場合、項目を開くだけで変化が生じます）
   - 「顔と目の可動・追従範囲」の項目に「正面角度」、「顔の上追従割合」、「顔の下追従割合」、「顔の横追従割合」、「顔の横回転傾き連動」を追加
 - 0.2.15.9
   - VRモード、カラオケモードなどで胸サブポジションが反映されていなかったのを修正
 - 0.2.15.8
   - MaidVoicePitchSlider.xmlを変更後エディットシーンを開き、セーブせずにロードして同じメイドをエディットシーンで開くと変更前の拡張値となってしまっていた問題を修正
   - ウェストの拡張が反映されていなかったのを修正（MaidVoicePitchSlider.xmlの修正。自分でカスタマイズしている方は次のように修正してください「West」→「west」）
   - 拡張スライダー項目に項目「尻スケーリング」「尻の位置」「膝の位置」「ももねじれ肉の位置」「もも肉の位置」「ももねじれ肉のスケーリング」「もも肉のスケーリング」を追加（ModsParam.xmlも変更があります）
 - 0.2.15.7
   - 拡張スライダー項目に「背骨の位置」と「鎖骨の位置」を追加（ModsParam.xmlも変更があります）
 - 0.2.15.6
   - VAスタジオモードをエディットシーンから起動した場合に口パクがうまく動作しないのを修正
   - 「顔と目の可動・追従範囲」がオンの場合に、エディットシーンのパーツの位置設定中にも顔が動いてしまっていたのを修正
 - 0.2.15.5
   - ExPresetの修正に合わせて処理を修正(使い方はMaidVoicePitch等のソースを参照)
 - 0.2.15.4
   - COM3D2の追加項目について、スライダー拡張時の変更量の計算誤りを修正。（「眉の上下」「眼球の上下」「眼球の縦のサイズ」「眼球の横のサイズ」）
   - 変更量の修正に合わせて、「MaidVoicePitchSlider.xml」の範囲を修正（「眼球の縦のサイズ」「眼球の横のサイズ」）
 - 0.2.15.3
   - Sybaris2対応
     - MaidVoicePitchSlider.xml読み込み場所をdllと同じフォルダのConfigフォルダ配下に変更
   - スライダーがマイナスの場合に、カテゴリを開くたびに数値が動く問題を修正
   - 「顔と目の可動・追従範囲」をオンにしたときに顔の初期向きが首の正面を向くように修正
 - 0.2.15.2
   - 胸スケーリングをいじっている場合に、シーンによってはおかしくなってしまう問題を対処
 - 0.2.15.1
   - 胸スケーリングが機能していなかった問題を対処
 - 0.2.15
   - COM3D2に対応
 - 0.2.12
   - 公式パッチ 1.15 対応
     - @PropSet等のスクリプトフックが動作していなかったのを修正 (その５>>376, >>378)
         - `class BaseKagManager { private static Maid GetMaidAndMan(KagTagSupport tag_data); }` が `class BaseKagManager { public Maid GetMaidAndMan(KagTagSupport tag_data); }` に変更されたのに対応
   - ドキュメントの構成を変更
 - 0.2.11
   - フリーコメント機能を削除
   - EYE_RATIOを削除
   - プラグインフィルタを削除
   - コンパイル時に警告が出ていたのを修正
 - 0.2.10
   - エディット画面でカテゴリを移動するたびに負の値のスライダーの値が変更されていたのを修正 (その４>>350)
 - 0.2.9
   - 1.11対応。目の縦横サイズ指定が入ったので以下を修正
     - BoneMorph_およびバニラセーブデータ内のEyeSclX, EyeSclYに対応
     - EYE_RATIOは削除予定
 - 0.2.8
   - ２人目以降のメイドに対してWIDESLIDERが正常に動作していなかったのを修正 (その３>>263, >>274, >>276, >>277)
   - 同、スライダーテンプレートが正常に設定されていなかったのを修正
 - 0.2.7
   - AddModsSlider用の[スライダーコールバック名をMaidVoicePitch_UpdateSlidersに変更](https://github.com/CM3D2-01/CM3D2.AddModsSlider.Plugin/compare/decf77137a...37e285d14f)
   - デフォルトのスライダーテンプレートを追加 (その３>>223, >>226)
   - FARMFIX等のトグル操作がその場で反映されないのを修正 (その３>>228)
 - 0.2.6
   - AddModsSlider用のスライダーコールバックUpdateSlidersを追加
 - 0.2.5
   - 顔がモーションに追従している場合はオフセット角度をつけないように修正 (その２>>41)
 - 0.2.4
   - README.mdに拡張セーブデータ、SLIDER_TEMPLATE、FACE_SCRIPT_TEMPLATEの説明を追加
   - 毎フレーム更新する対象を削減
   - いくつかのパラメーターを廃止
     - FACE_ANIME_SPEED (表情アニメーション速度) 廃止
     - MABATAKI_SPEED (まばたき速度) 廃止
     - PELVIS (骨盤部と衣装のコリジョン) 廃止 (PELVIS, PELVIS.x, PELVIS.y, PELVIS.z)
   - いくつかのパラメーターの動作を変更
     - AddModsSlider 0.1.0.7 で LIPSYNC が正常に動作していなかったため、仕様を変更
     - EYE_ANG.angleで目の角度を変えた際、眼球の角度の補正を追加
   - 顔と目の動作改善を追加
     - 顔の制御 HEAD_TRACK { .lateral, .above, .below, .behind, .speed, .ofsx, .ofsy }
       - HEAD_TRACK.lateral : 左右の角度制限
       - HEAD_TRACK.above : 上方の角度制限
       - HEAD_TRACK.below : 下方の角度制限
       - HEAD_TRACK.behind : 追従をあきらめる角度
       - HEAD_TRACK.speed : 追従速度
     - 目の制御 EYE_TRACK { .inside, .outside, .above, .below, .behind, .speed, .ofsx, .ofsy }
       - EYE_TRACK.inside : 内側の角度制限
       - EYE_TRACK.outside : 外側の角度制限
       - EYE_TRACK.above : 上方の角度制限
       - EYE_TRACK.below : 下方の角度制限
       - EYE_TRACK.behind : 追従をあきらめる角度
       - EYE_TRACK.speed : 追従速度
       - EYE_TRACK.ofsx : 横方向の中央位置の補正値 (負の値でより目、0でデフォルト、正の値で離れ目)
       - EYE_TRACK.speed : 縦方向の中央位置の補正値 (負の値で下、0でデフォルト、正の値で上)
  - ModsParam.xml への追加例
```
<mod id="HEAD_TRACK" description="顔の追従処理の改善">
    <value prop_name="HEAD_TRACK.lateral" min="1"   max="90"  label="横角"   type="num" />
    <value prop_name="HEAD_TRACK.above"   min="1"   max="90"  label="上角"   type="num" />
    <value prop_name="HEAD_TRACK.below"   min="1"   max="90"  label="下角"   type="num" />
    <value prop_name="HEAD_TRACK.behind"  min="1"   max="180" label="無視角" type="num" />
    <value prop_name="HEAD_TRACK.speed"   min="0"   max="0.3" label="速度"   type="num" />
    <value prop_name="HEAD_TRACK.ofsx"    min="-30" max="30"  label="横オ"   type="num" />
    <value prop_name="HEAD_TRACK.ofsy"    min="-30" max="30"  label="縦オ"   type="num" />
    <value prop_name="HEAD_TRACK.ofsz"    min="-30" max="30"  label="回オ"   type="num" />
</mod>

<mod id="EYE_TRACK" description="目の追従処理の改善">
    <value prop_name="EYE_TRACK.outside" min="1"   max="90"  label="内角"   type="num" />
    <value prop_name="EYE_TRACK.inside"  min="1"   max="90"  label="外角"   type="num" />
    <value prop_name="EYE_TRACK.above"   min="-10" max="90"  label="上角"   type="num" />
    <value prop_name="EYE_TRACK.below"   min="-10" max="90"  label="下角"   type="num" />
    <value prop_name="EYE_TRACK.behind"  min="1"   max="180" label="無視角" type="num" />
    <value prop_name="EYE_TRACK.speed"   min="0"   max="0.3" label="速度"   type="num" />
    <value prop_name="EYE_TRACK.ofsx"    min="-10" max="10"  label="横オ"   type="num" />
    <value prop_name="EYE_TRACK.ofsy"    min="-5"  max="5"   label="縦オ"   type="num" />
</mod>
```
 - 0.2.13
   - 公式パッチ 1.23 対応
     - 撮影モードで表情追加オプションが動作していなかったのを暫定修正
 - 0.2.12
   - 公式パッチ 1.15 対応
     - @PropSet等のスクリプトフックが動作していなかったのを修正 (その５>>376, >>378)
         - `class BaseKagManager { private static Maid GetMaidAndMan(KagTagSupport tag_data); }` が `class BaseKagManager { public Maid GetMaidAndMan(KagTagSupport tag_data); }` に変更されたのに対応
   - ドキュメントの構成を変更
 - 0.2.11
   - フリーコメント機能を削除
   - EYE_RATIOを削除
   - プラグインフィルタを削除
   - コンパイル時に警告が出ていたのを修正
 - 0.2.10
   - エディット画面でカテゴリを移動するたびに負の値のスライダーの値が変更されていたのを修正 (その４>>350)
 - 0.2.9
   - 1.11対応。目の縦横サイズ指定が入ったので以下を修正
     - BoneMorph_およびバニラセーブデータ内のEyeSclX, EyeSclYに対応
     - EYE_RATIOは削除予定
 - 0.2.7
   - デフォルトのスライダーテンプレートファイル "UnityInjector/Config/MaidVoicePitchSlider.xml" を追加
      - スライダーテンプレートが指定されていない場合、このファイルを用いるようになります
 - 0.2.3
   - 使用しなくなった拡張セーブデータを削除する処理を追加
 - 0.2.2
   - @Faceコマンドを無視する「FACE_OFF」を追加 (Trueで無視、Falseで通常通り) (その２>>433)
   - @FaceBlendコマンドを無視する「FACEBLEND_OFF」を追加 (Trueで無視、Falseで通常通り) (その２>>433)
   - 「SLIDER_TEMPLATE」の読み込みをしていなかったのを修正 (その２>>504, >>508)
   - 「*.enable」系の名称を変更。対象は "PELVIS.enable", "FARMFIX.enable", "SPISCL.enable", "S0ASCL.enable", "S1_SCL.enable", "S1ASCL.enable" (その２>>509)
 - 0.2.1
   - 骨盤コリジョンスイッチ "PELVIS.enable" を追加
   - 前腕のゆがみ修正 "FARMFIX.enable" を追加 (その２>>89, ForeArmFix)
   - 胴スケール指定 "SPISCL.*", "S0ASCL.*", "S1_SCL.*", "S1ASCL.*" を追加 (*はenable, width, depth, height) (その２>>90, SpineScale)
   - スカートスケール指定 "SKTSCL.*" を追加 (*はenable, width, depth, height) (その２>>218)
 - 0.2.0
   - 拡張セーブデータに移行
 - 0.1.11
    - EYETOCAM#" が指定されていない場合に、瞳が動かなくなるバグを修正 (その２>>216, >>217, >>219)
 - 0.1.10
    - PROPSET_OFF#" 等が正常に動作しないときがあるのを修正 (その２>>89, >>96, >>141)
 - 0.1.9
   - - スケール指定 "#TEST_PELSCL=W.WW,D.DD,H.HH#" を追加 (テスト中) (その１>>961, >>970)
   - 脚部スケール指定 "#TEST_THISCL=W.WW,D.DD#" を追加 (テスト中) (その１>>961, >>970)
   - 股関節位置指定 "#TEST_THIPOS=X.XX,Z.ZZ#" を追加 (テスト中) (その１>>961, >>970)
 - 0.1.8
    - EyeToCameraを無視する "#TEST_EYETOCAMERA_OFF#" を追加 (テスト中) (その1>>697)
    - スライダー範囲指定 "#TEST_SLIDER_TEMPLATE=filename#" を追加 (テスト中) (その１>>804, >>807, その２>>11, >>12)
    - 目の縦横比変更 "#TEST_EYE_RATIO=N.NN#" を追加 (その1>>923, EyeScaleRotate)
    - 目の角度変更 "#TEST_EYE_ANG=N.NN,X.XX,Y.YY#" を追加 (その1>>923, EyeScaleRotate)
 - 0.1.7
    - 版でも動作するように修正 (その1>>592)
    - スライダー範囲拡大の名称を "#WIDESLIDER#" に変更
    - @PropSet無視の名称を "#PROPSET_OFF#" に変更
    - まばたき範囲指定を "#MABATAKI=N.NN#" に仕様変更
    - 瞳サイズ変更 "#EYEBALL=N.NN,M.MM#" を追加
    - リップシンク強度指定 "#TEST_LIPSYNC=N.NN#" を追加 (テスト中) (その1>>624)
    - まばたき速度指定 "#TEST_MABATAKI_SPEED=N.NN#" を追加 (テスト中)
    - 表情変化速度指定 "#TEST_FACE_ANIME_SPEED=N.NN#" を追加 (テスト中)
    - 骨盤部コリジョン指定 "#TEST_PELVIS=X.XX,Y.YY,Z.ZZ#" を追加 (テスト中)
    - 表情テンプレート指定 "#TEST_FACE_SCRIPT_TEMPLATE=filename# を追加 (テスト中)
 - 0.1.6
   - コンパイルバグ修正その２ (その1>>541)
 - 0.1.5
   - バグ修正
 - 0.1.4
   - 夜伽スクリプトでの@PropSetの動作を制限する指定 "#TEST_PROPSET_OFF#" を追加 (その1>>466)
 - 0.1.3
   - UnityInjectorベースに変更 (その1>>436)
   - まばたき範囲指定 "#MABATAKI=N.NN,M.MM#" を追加
   - 表情変化オフ指定 "#HYOUJOU_OFF#" を追加
   - リップシンクオフ指定 "#LIPSYNC_OFF#" を追加
   - 目をカメラに向ける指定 "#EYETOCAM#" を追加
   - 顔をカメラに向ける指定 "#HEADTOCAM#" を追加
 - 0.1.2
   - 説明を修正 (その1>>391)
   - ピッチ指定を "#PITCH=N.NN#" に変更
   - 無表情指定 "#MUHYOU#" を追加
 - 0.1.1
   - 説明を修正 (その1>>306)
   - フリーコメント欄が空の場合に正常に動作していなかったのを修正 (その1>>308)
 - 0.1.0
   - 最初の版
