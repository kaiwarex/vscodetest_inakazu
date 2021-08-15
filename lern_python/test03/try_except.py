while True:
    num = input("何個ですか？(qで終了)")
    if num == "q":
        print("終了しました")
        #処理の終了
        break
    #入力された値を整数に変換出来ない場合、例外処理を行う
    try:
        price = 120 * int(num)
        print("金額",price)
    except:
        print("エラーです。正しい数値を入れてください")    


