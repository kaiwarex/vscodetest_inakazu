#randomモジュールのrandint関数を読み込む
from random import randint
a = randint(0,100)
b = randint(0,100)

def judge_two_val(a,b):
    if a >= 40 and b >= 40 and (a+b) >= 120:
        result = "合格"
        return result
    else:
        result = "不合格"
        return result
ans_str = judge_two_val(a,b)

text = f"a{a},b{b},合計{a + b}:{ans_str}"
print(text)