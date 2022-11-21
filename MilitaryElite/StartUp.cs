using MilitaryElite.Core;
using MilitaryElite.Core.Interfaces;
using MilitaryElite.IO;
using MilitaryElite.IO.Interfaces;
using MilitaryElite.Models;
using MilitaryElite.Models.Interfaces;
using System;

namespace MilitaryElite
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IEngine engine = new Engine(reader, writer);
            engine.Run();

        }
    }
}
