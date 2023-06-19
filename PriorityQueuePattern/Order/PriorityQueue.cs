
// 優先隊列類別
public class PriorityQueue
{
    private Queue<OrderRequest> highPriorityQueue;
    private Queue<OrderRequest> normalPriorityQueue;

    public PriorityQueue()
    {
        highPriorityQueue = new Queue<OrderRequest>();
        normalPriorityQueue = new Queue<OrderRequest>();
    }

    public void Enqueue(OrderRequest request)
    {
        if (request.Priority == 1)
        {
            highPriorityQueue.Enqueue(request);
        }
        else
        {
            normalPriorityQueue.Enqueue(request);
        }
    }

    public OrderRequest Dequeue()
    {
        if (highPriorityQueue.Count > 0)
        {
            return highPriorityQueue.Dequeue();
        }
        else if (normalPriorityQueue.Count > 0)
        {
            return normalPriorityQueue.Dequeue();
        }
        else
        {
            return null;
        }
    }
}
