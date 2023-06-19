
// 音樂播放器類別
public class MusicPlayer
{
    private ISong currentSong;

    public void SetSong(ISong song)
    {
        currentSong = song;
    }

    public void Play()
    {
        currentSong.Play();
    }

    public void Stop()
    {
        currentSong.Stop();
    }
}
