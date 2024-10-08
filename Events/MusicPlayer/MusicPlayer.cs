﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp.Events.MusicPlayer;

// Define delegete for an event
public delegate void PlaybackEventHandler(string message);

public class MusicPlayer
{
    // Events that user can subscribe
    public event PlaybackEventHandler OnPlay;
    public event PlaybackEventHandler OnPause;
    public event PlaybackEventHandler OnStop;
    public event PlaybackEventHandler OnSkip;

    public string currentTrack;

    public MusicPlayer()
    {
        currentTrack = "Not Selected";
    }

    // Method to select track
    public void SelectTrack(string track)
    {
        currentTrack = track;
        Console.WriteLine($"Track Selected {currentTrack}");
    }

    public void Play(string track)
    {
        currentTrack = track;
        OnPlay?.Invoke($"Playing Track {currentTrack}");
    }

    public void Pause(PlaybackEventHandler playbackEvent)
    {
        playbackEvent($"Pausing Track {currentTrack}"); // Call delegate callback instead invoking event
    }

    public void Stop()
    {
        OnStop?.Invoke($"Stoping Track {currentTrack}");
    }

    public void Skip(string nextTrack)
    {
        currentTrack = nextTrack;
        OnSkip?.Invoke($"Skipped To Track {currentTrack}");
    }
}
