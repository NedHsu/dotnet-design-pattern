public class ShoppingCart
{
    private static ShoppingCart instance;
    private static readonly object lockObject = new object();

    private ShoppingCart()
    {
        // 私有化建構子，防止直接實例化
    }

    public static ShoppingCart GetInstance()
    {
        // 雙重檢查鎖定
        if (instance == null)
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new ShoppingCart();
                }
            }
        }
        return instance;
    }

    public void AddItem(string item)
    {
        // 添加商品到購物車
        Console.WriteLine("Adding item to shopping cart: " + item);
    }

    // 其他購物車相關方法...
}
