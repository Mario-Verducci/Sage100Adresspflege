using Sage100Adresspflege;

DvdPlayer dvdPlayer = new DvdPlayer();
StromEinAus(dvdPlayer);
VideoAbspielen(dvdPlayer);

static void StromEinAus(IStromverbraucher stromverbraucher)
{
    stromverbraucher.StromAn();
    stromverbraucher.StromAus();
}

static void VideoAbspielen(IVideoPlayer videoPlayer)
{
    videoPlayer.Play();
    videoPlayer.Pause();
    videoPlayer.Stop();
    videoPlayer.Forward();
    videoPlayer.Rewind();
}

// ISnackbar -> Benachrichtungen die von unten nach oben eingeblendet werden