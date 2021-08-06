print("Hello Python!")
print('3つの整数の最大値を求めます')
a = int(input('整数aの値:'))
b = int(input('整数bの値'))
c = int(input('整数cの値'))

maximum1 = a
if b > maximum1: maximum1 = b
if c > maximum1: maximum1 = c

print(f'最大値は{maximum1}です')    