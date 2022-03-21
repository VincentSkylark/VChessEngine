using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace UCIEngine.Engine
{
    class GameEngine
    {
        public void Run()
        {
            string command;

            // game loop
            while (true)
            {
                command = Console.ReadLine();
                ParseCommand(command);
            }
        }

        private void ParseCommand(string command)
        {

        }

        private static Dictionary<string, Action<string[]>> GUICommandDict = new Dictionary<string, Action<string[]>>(StringComparer.InvariantCulture)
        {
            ["uci"] = Uci,
            ["debug"] = NotImplement,
            ["isready"] = NotImplement,
            ["setoption"] = NotImplement,
            ["register"] = NotImplement,
            ["ucinewgame"] = NotImplement,
            ["position "] = NotImplement,
            ["go"] = NotImplement,
            ["stop"] = NotImplement,
            ["ponderhit"] = NotImplement,
            ["quit"] = NotImplement
        };

        private static void NotImplement(string[] args)
        {

        }
        private static void Uci(string[] args)
        {

        }


    }
}
