sum = 50 + 37 + 10
limit = 100

if sum >= limit:
    result = "合格"
else:
    result = "不合格"
    result += "/" + str(sum-limit)

print(sum)
print("-" * 20)
print(result)
    