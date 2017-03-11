using FarManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int cursor = 0;
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\HP\Documents\Visual Studio 2015");
            qwerty.writeAll(dir, cursor);
        }
    }
}