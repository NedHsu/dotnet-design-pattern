
// 實現寫作家類別
public class Writer : IWriter
{
    public void Write(string content)
    {
        Console.WriteLine("Writing: " + content);
    }
}
