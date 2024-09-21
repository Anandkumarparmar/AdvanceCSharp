namespace AdvanceCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Delegate with event example
            RunMusicPlayer();
        }

        // Run the music player interface
        public static void RunMusicPlayer()
        {
            var musicPlayer = new MusicPlayer();
            var musicSubscriber1 = new MusicSubscriber("Subscriber 1", musicPlayer);
            var musicSubscriber2 = new MusicSubscriber("Subscriber 2", musicPlayer);

            while (true)
            {
                Console.WriteLine("\nOptions: Play | Pause | Stop | Skip | Select Track | Exit");
                Console.Write("Enter command: ");

                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "play":
                        Console.Write("Enter song to play: ");
                        string songToPlay = Console.ReadLine();
                        musicPlayer.Play(songToPlay);
                        break;
                    case "pause":
                        musicPlayer.Pause(DisplayMessage); // Achieve using delegate callbacks // Tightly coupled
                        break;
                    case "stop":
                        musicPlayer.Stop();
                        break;
                    case "skip":
                        Console.Write("Enter next track name: ");
                        string nextTrack = Console.ReadLine();
                        musicPlayer.Skip(nextTrack);
                        break;
                    case "select track":
                        Console.Write("Enter track name: ");
                        string track = Console.ReadLine();
                        musicPlayer.SelectTrack(track);
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
            }
        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine($"Multiple Subscribers issue received notification: {message}");
        }
    }
}
