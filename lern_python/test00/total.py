#配列なし
print('5人の点数の合計と平均を求める')

tensu_1 = int(input('1番目の点数'))
tensu_2 = int(input('2番目の点数'))
tensu_3 = int(input('3番目の点数'))
tensu_4 = int(input('6番目の点数'))
tensu_5 = int(input('5番目の点数'))

total = 0
total += tensu_1
total += tensu_2
total += tensu_3
total += tensu_4
total += tensu_5

print(f'合計は{total}点です')
print(f'平均は{total / 5}点です')