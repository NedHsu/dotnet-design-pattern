
// 音響子系統
public class AudioSystem
{
    public void TurnOn()
    {
        Console.WriteLine("Audio system is turned on.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Audio system is turned off.");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine("Audio system volume is set to " + volume);
    }
}
