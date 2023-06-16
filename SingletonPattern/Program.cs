CEO ceo1 = CEO.GetInstance();
CEO ceo2 = CEO.GetInstance();

// 因為只能創建一個 CEO 實例，所以 ceo1 和 ceo2 是同一個實例
Console.WriteLine(ceo1 == ceo2); // 輸出: True

ceo1.DoWork();