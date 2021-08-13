from random import randint

numbers = [] #空のリスト
#numbersの値が10個になるまで繰り返す
while len(numbers) < 10:
    n = randint(0,100)
    if n in numbers:
        #nがnumbersに含まれていたらスキップする
        continue
    #numbersにnを追加する
    numbers.append(n) #はじめての数値ならばnumberリストに追加する

print(numbers)