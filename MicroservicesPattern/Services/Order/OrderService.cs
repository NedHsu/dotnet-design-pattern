public class OrderService
{
    public void CreateOrder(string userId, List<string> productIds)
    {
        // 處理訂單創建邏輯
    }

    public Order GetOrder(string orderId)
    {
        // 獲取訂單資料邏輯
        var order = new Order();
        return order;
    }

    public void PayOrder(string orderId)
    {
        // 處理訂單支付邏輯
    }
}
