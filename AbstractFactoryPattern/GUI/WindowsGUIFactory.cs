// 具體的 Windows 工廠
public class WindowsGUIFactory : IGUIFactory
{
    public Button CreateButton()
    {
        return new WindowsButton();
    }

    public TextBox CreateTextBox()
    {
        return new WindowsTextBox();
    }

    public Label CreateLabel()
    {
        return new WindowsLabel();
    }
}