// 具體 MacOS 控制元件類別
public class MacOSButton : Button
{
    public override void Render()
    {
        Console.WriteLine("Render MacOSButton");
    }
}

public class MacOSTextBox : TextBox
{
    public override void Render()
    {
        Console.WriteLine("Render MacOSTextBox");
    }
}

public class MacOSLabel : Label
{
    public override void Render()
    {
        Console.WriteLine("Render MacOSLabel");
    }
}