namespace Sage100Adresspflege;

public interface IVideoPlayer
{
    string Name { get; }

    void Play();
    void Pause();
    void Stop();
    void Forward();
    void Rewind();
}