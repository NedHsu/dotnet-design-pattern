
// 主題（報社）

// 訂閱者（讀者）

// 報社
public class Newspaper : ISubject
{
    private List<IObserver> observers;
    private string latestNews;

    public Newspaper()
    {
        observers = new List<IObserver>();
    }

    public void Register(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Unregister(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update(latestNews);
        }
    }

    public void PublishNews(string news)
    {
        latestNews = news;
        Notify();
    }
}

// 輸出:
// Reader John received news: Breaking News: COVID-19 vaccine approved!
// Reader Alice received news: Breaking News: COVID-19 vaccine approved!
// Reader John received news: Sports: Home team wins the championship!
