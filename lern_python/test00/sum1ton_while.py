print('1からnまでの総和を求めますよ')
n = int(input('nの値:'))

sum = 0
i = 1

while i <= n:
    sum += i
    i += 1

print(f'1から{n}までの総和は{sum}です')