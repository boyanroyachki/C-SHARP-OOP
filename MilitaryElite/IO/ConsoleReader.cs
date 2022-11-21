using MilitaryElite.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
            => Console.ReadLine();


    }

}
