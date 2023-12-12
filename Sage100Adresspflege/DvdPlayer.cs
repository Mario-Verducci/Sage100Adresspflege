namespace Sage100Adresspflege;

public class DvdPlayer : IVideoPlayer, IStromverbraucher
{
    public string Name { get; } = "DVD Player";

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

    public void MenuAufrufen()
    {
        Console.WriteLine($"Es wurde am {Name} das Menü aufgerufen");
    }

    public void StromAn()
    {
        Console.WriteLine("Strom an");
    }

    public void StromAus()
    {
        Console.WriteLine("Strom aus");
    }
}