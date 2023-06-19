
// 空歌曲類別
public class NullSong : ISong
{
    public void Play()
    {
        Console.WriteLine("No song selected");
    }

    public void Stop()
    {
        Console.WriteLine("No song selected");
    }
}
