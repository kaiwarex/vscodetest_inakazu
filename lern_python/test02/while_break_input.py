from random import randint
miss = 0
correct = 0
print("3回間違えたら即終了。qでとめる")

while miss <3:
    a = randint(1,100)
    b = randint(1,100)
    ans = a + b
    #問題を出題しキーボードからの入力まちにする
    question = f"{a}+{b}は？"
    value = input(question)
    # qと入力されたら中断する
    if value == "q":
        break #ブレイクする
    #解答が正解かどうか判定する
    if value == str(ans):
        correct += 1
        print("正解です")
    else:
        miss += 1
        print("間違い！","✗"*miss)#間違いの数だけ✗を表示する

print("-" * 20)
print("正解",correct)
print("間違い:",miss)