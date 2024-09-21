using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdvanceCSharp;

public class MusicSubscriber
{
    private readonly MusicPlayer _musicPlayer;
    private readonly string _subscriber;

    public MusicSubscriber(string subscriber, MusicPlayer musicPlayer)
    {
        _subscriber = subscriber;
        _musicPlayer = musicPlayer;

        // Subscribes the music player events
        _musicPlayer.OnPlay += DisplayMessage;
        _musicPlayer.OnPause += DisplayMessage;
        _musicPlayer.OnStop += DisplayMessage;
        _musicPlayer.OnSkip += DisplayMessage;
    }

    // Message to handle display method for events
    private void DisplayMessage(string message)
    {
        Console.WriteLine($"{_subscriber} received notification: {message}");
    }
}
