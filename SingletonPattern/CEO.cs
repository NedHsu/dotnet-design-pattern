public class CEO
{
    private static CEO _instance;

    // 私有的構造函式，防止外部創建實例
    private CEO()
    {
        // 執行初始化操作
    }

    // 全域的訪問點，用於獲取唯一的 CEO 實例
    public static CEO GetInstance()
    {
        if (_instance == null)
        {
            // 如果實例為空，則創建一個新的 CEO 實例
            _instance = new CEO();
        }

        return _instance;
    }

    public void DoWork()
    {
        // 執行 CEO 的工作任務
    }
}