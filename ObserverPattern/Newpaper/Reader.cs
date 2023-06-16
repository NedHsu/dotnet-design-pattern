
// 主題（報社）

// 訂閱者（讀者）

// 報社

// 讀者
public class Reader : IObserver
{
    public string Name { get; }

    public Reader(string name)
    {
        Name = name;
    }

    public void Update(string news)
    {
        Console.WriteLine($"Reader {Name} received news: {news}");
    }
}

// 輸出:
// Reader John received news: Breaking News: COVID-19 vaccine approved!
// Reader Alice received news: Breaking News: COVID-19 vaccine approved!
// Reader John received news: Sports: Home team wins the championship!
