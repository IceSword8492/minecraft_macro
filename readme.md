# usage

1. 各ファイルの`#load`を正しいパスに書き換える。
2. 座標設定を切り替える際は`createhotpotatobook.csx`のヘッダ部分にある`#load`を書き換えて切り替える。使用するファイルは以下の通り。

|file|resolution|gui scale|mode|
|---|---|---|---|
|slot.csx|1920x1200|normal|windowed|
|slot_note.csx|1920x1080|normal|windowed|

3. クラフト時、購入時の操作待機時間は以下を書き換えることにより変更可能。(ms)
```cs
int craftDelay = 150;
int buyDelay = 750;
```
4. ループ回数は以下を書き換えることにより変更可能。
```cs
int loopCount = 1;
```
5. 運用時はホットバーの左4つを埋め、エンダーチェストの下二段を空けておく。

# known issues

1. 途中で中止不能。(止めたい場合はk2kを強制終了する。)
2. ファイル名が`createhotpotatobook.csx`であるのに実際に作成されるのは`enchanted baked potato`である。
3. エンダーチェストが5段でない場合座標がずれる。
4. 作成の最後の段階でやたら操作が早くなる。
5. チェストにしまう動作がなんかかわいい。
6. 購入数が足りなかった場合未定義動作を引き起こす。
7. 1st以上作成した場合、エンダーチェストに収納できず未定義動作を引き起こす。