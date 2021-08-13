from typing import Any,Sequence

def max_of(a: Sequence) -> Any:
    maximum = a[0]
    for i in range(1,len(a)):
        if a[i] > maximum:
            maximum = a[i]
    return maximum

if __name__ == '__main__':
    num = int(input('要素数:'))
    x = [None] * num

    for i in range(num):
        x[i] = int(input(f'x[{1}]:'))


    print(f'最大値は{max_of(x)}です')


