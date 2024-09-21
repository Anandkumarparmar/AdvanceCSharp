using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp;

public class MusicPlayerUI
{
    private readonly MusicPlayer _musicPlayer;

    public MusicPlayerUI(MusicPlayer musicPlayer)
    {
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
        Console.WriteLine(message);
    }

    // Run the music player interface
    public void Run()
    {
        Console.WriteLine("\nOptions: Play | Pause | Stop | Skip | Select Track | Exit");
        Console.Write("Enter command: ");

        string command = Console.ReadLine().ToLower();

        switch (command)
        {
            case "play":
                _musicPlayer.Play(DisplayMessage); // Achieve using delegate callbacks // Tightly coupled
                break;
            case "pause":
                _musicPlayer.Pause(); // Achieve using events
                break;
            case "stop":
                _musicPlayer.Stop();
                break;
            case "skip":
                Console.Write("Enter next track name: ");
                string nextTrack = Console.ReadLine();
                _musicPlayer.Skip(nextTrack);
                break;
            case "select track":
                Console.Write("Enter track name: ");
                string track = Console.ReadLine();
                _musicPlayer.SelectTrack(track);
                break;
            case "exit":
                return;
            default:
                Console.WriteLine("Invalid command.");
                break;
        }
    }

}
