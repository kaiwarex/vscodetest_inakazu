#randomモジュールのrandint関数を読み込む
from random import randint
size = randint(5,20)
weight = randint(20,40)

#判定
if size >= 10:
    if weight >= 25:
        result="合格"
    else:
        result="不合格"
else:
    result = "不合格"

#結果の出力
text = f"サイズ{size},重量{weight}:{result}"
print(text)

#1稲員メソッド
def inakazu_m():
    print("稲員でした〜")

inakazu_m()