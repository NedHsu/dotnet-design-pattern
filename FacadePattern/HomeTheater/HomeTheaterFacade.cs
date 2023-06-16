
// 家庭影院外觀類別
public class HomeTheaterFacade
{
    private Projector projector;
    private AudioSystem audioSystem;
    private DVDPlayer dvdPlayer;

    public HomeTheaterFacade()
    {
        projector = new Projector();
        audioSystem = new AudioSystem();
        dvdPlayer = new DVDPlayer();
    }

    public void WatchMovie()
    {
        Console.WriteLine("Preparing the home theater system for watching a movie...");
        projector.TurnOn();
        audioSystem.TurnOn();
        dvdPlayer.TurnOn();

        projector.SetInput("DVD Player");
        audioSystem.SetVolume(10);

        dvdPlayer.Play();
    }

    public void StopMovie()
    {
        Console.WriteLine("Stopping the movie and turning off the home theater system...");
        dvdPlayer.TurnOff();
        audioSystem.TurnOff();
        projector.TurnOff();
    }
}
