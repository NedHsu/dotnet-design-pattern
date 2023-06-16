// 具體 Windows 控制元件類別
public class WindowsButton : Button
{
    public override void Render()
    {
        Console.WriteLine("Render WindowsButton");
    }
}

public class WindowsTextBox : TextBox
{
    public override void Render()
    {
        Console.WriteLine("Render WindowsTextBox");
    }
}

public class WindowsLabel : Label
{
    public override void Render()
    {
        Console.WriteLine("Render WindowsLabel");
    }
}