
// 使用範例
PriorityQueue priorityQueue = new PriorityQueue();

// 優先級高的點餐請求
OrderRequest request1 = new OrderRequest
{
    CustomerName = "VIP Customer",
    Priority = 1,
    OrderDetails = "Special breakfast set"
};

// 優先級普通的點餐請求
OrderRequest request2 = new OrderRequest
{
    CustomerName = "Regular Customer",
    Priority = 2,
    OrderDetails = "Basic breakfast set"
};

priorityQueue.Enqueue(request1);
priorityQueue.Enqueue(request2);

// 處理點餐請求
OrderRequest processedRequest = priorityQueue.Dequeue();
Console.WriteLine($"Processing order for: {processedRequest.CustomerName}, Order: {processedRequest.OrderDetails}");
