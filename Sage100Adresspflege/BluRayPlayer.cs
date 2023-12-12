using Sage100Adresspflege;

public class BluRayPlayer : IVideoPlayer
{
    public string Name { get; } = "BluRay Player";

    public void Play()
    {
        Console.WriteLine($"Es wurde am {Name} Play gedrückt");
    }

    public void Pause()
    {
        Console.WriteLine($"Es wurde am {Name} Pause gedrückt");
    }

    public void Stop()
    {
        Console.WriteLine($"Es wurde am {Name} Stop gedrückt");
    }

    public void Forward()
    {
        Console.WriteLine($"Es wurde am {Name} Forward gedrückt");
    }

    public void Rewind()
    {
        Console.WriteLine($"Es wurde am {Name} Rewind gedrückt");
    }
}