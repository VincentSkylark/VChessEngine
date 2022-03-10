using System;
using System.IO;
using System.Text;
using System.Threading;

namespace UCIEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream inputStream = Console.OpenStandardInput(); // can set stream type, buffer size
            Console.SetIn(new StreamReader(inputStream, Encoding.ASCII, false));
            Engine.GameEngine engine = new Engine.GameEngine();
            var gameThread = new Thread(engine.Run);
            gameThread.Start();
        }
    }
}
