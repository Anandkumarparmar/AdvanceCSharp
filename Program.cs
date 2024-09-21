namespace AdvanceCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Delegate with event example

            var player = new MusicPlayer();
            var musicPlayerUI = new MusicPlayerUI(player);

            musicPlayerUI.Run();    
        }
    }
}
