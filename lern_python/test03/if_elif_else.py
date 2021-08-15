from random import randint
point = randint(0,100)
if point >= 80:
    result = "Aクラス"
elif point >= 60:
    result = "Bクラス"
else:
    result = "社会不適合者"

#結果の出力
print(f"{point}点：{result}")