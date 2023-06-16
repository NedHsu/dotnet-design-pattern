// 具體的 MacOS 工廠
public class MacOSGUIFactory : IGUIFactory
{
    public Button CreateButton()
    {
        return new MacOSButton();
    }

    public TextBox CreateTextBox()
    {
        return new MacOSTextBox();
    }

    public Label CreateLabel()
    {
        return new MacOSLabel();
    }
}