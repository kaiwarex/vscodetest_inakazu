from random import randint
nnnnnnu = []
while len(nnnnnnu) < 10:
    n = randint(-10,90)
    if n < 0:
        #nがマイナスならブレイクする
        print("中断されました")
        break

    if n in nnnnnnu:
        continue
    
    nnnnnnu.append(n)
else:
    print(nnnnnnu)