sum = 7600
while True:
    num= input("何人ですか？(qで終了)")
    if num == "q":
        print("qが押下されたので終了します")
        break
    #例外を処理する
    try:
        price = round(sum/int(num))
    except Exception as error:
        print("エラーになりました")
        print(error)
    else:
        if price < 0:
            #マイナス値は無視
            continue
        print("一人あたりの金額",price)