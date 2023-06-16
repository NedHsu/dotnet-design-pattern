
// 主題（報社）
public interface ISubject
{
    void Register(IObserver observer);  // 註冊訂閱者
    void Unregister(IObserver observer);  // 取消註冊訂閱者
    void Notify();  // 通知訂閱者
}

// 輸出:
// Reader John received news: Breaking News: COVID-19 vaccine approved!
// Reader Alice received news: Breaking News: COVID-19 vaccine approved!
// Reader John received news: Sports: Home team wins the championship!
