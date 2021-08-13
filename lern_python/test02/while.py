from random import randint
ticket = 5
point = 0
fmt = "{:>3}"
while ticket > 0:
    v = randint(1,20)
    print(fmt.format(v))
    point += v
    ticket -= 1

print("-" * 3)
print(fmt.format(point))