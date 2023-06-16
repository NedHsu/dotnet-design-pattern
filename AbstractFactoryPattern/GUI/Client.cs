// 用戶端代碼
public class Client
{
    private IGUIFactory _guiFactory;

    public Client(IGUIFactory guiFactory)
    {
        _guiFactory = guiFactory;
    }

    public void RenderUI()
    {
        Button button = _guiFactory.CreateButton();
        TextBox textBox = _guiFactory.CreateTextBox();
        Label label = _guiFactory.CreateLabel();

        button.Render();
        textBox.Render();
        label.Render();
    }
}