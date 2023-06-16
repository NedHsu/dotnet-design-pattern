// 抽象工廠介面
public interface IGUIFactory
{
    Button CreateButton();
    TextBox CreateTextBox();
    Label CreateLabel();
}