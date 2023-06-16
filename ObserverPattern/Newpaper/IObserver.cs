
// 主題（報社）

// 訂閱者（讀者）
public interface IObserver
{
    void Update(string news);  // 更新訊息
}

// 輸出:
// Reader John received news: Breaking News: COVID-19 vaccine approved!
// Reader Alice received news: Breaking News: COVID-19 vaccine approved!
// Reader John received news: Sports: Home team wins the championship!
