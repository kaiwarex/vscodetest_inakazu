from random import randint

#関数を定義する
def dice():
    num = randint(1,6)
    return num

#dice()を５回呼び出す
for i in range(5):
    result = dice()
    print(result)