
// 具體歌曲類別
public class Song : ISong
{
    private string title;
    private string artist;

    public Song(string title, string artist)
    {
        this.title = title;
        this.artist = artist;
    }

    public void Play()
    {
        Console.WriteLine($"Playing: {title} by {artist}");
    }

    public void Stop()
    {
        Console.WriteLine($"Stopping: {title}");
    }
}
