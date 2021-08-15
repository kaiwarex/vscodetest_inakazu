pos = int(input("取り出す位置:"))
colors = ["blue","red","green","yellow"]
#例外処理に組み込む
try:
    item = colors[pos]
    print(item)
except IndexError:
    print("インデックスエラーです")
except Exception as error:
    print(error)