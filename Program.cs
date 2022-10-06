using System;

namespace London_Jack // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Game_play director = new Game_play();
            director.StartGame();
            return 0;
        }
    }
}