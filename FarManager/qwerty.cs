using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarManager
{
    public class qwerty
    {
        public static void writeAll(DirectoryInfo dir, int cursor)
        {
            Console.Clear();
            FileSystemInfo[] qwert = dir.GetFileSystemInfos();
            for (int i = 0; i < qwert.Length; i++)
            {
                Console.BackgroundColor = (i == cursor) ? ConsoleColor.Green : ConsoleColor.Blue;
                Console.ForegroundColor = (qwert[i].GetType() == typeof(DirectoryInfo)) ? ConsoleColor.Cyan : ConsoleColor.DarkMagenta;
                Console.WriteLine(qwert[i].Name);
            }
            ConsoleKeyInfo btn = Console.ReadKey();
            switch (btn.Key)
            {
                case ConsoleKey.UpArrow:
                    if (cursor > 0)
                        cursor--;
                    writeAll(dir, cursor);
                    break;
                case ConsoleKey.DownArrow:
                    if (cursor <= qwert.Length)
                        cursor++;
                    writeAll(dir, cursor);
                    break;
                case ConsoleKey.Enter:
                    FileSystemInfo fs = dir.GetFileSystemInfos()[cursor];
                    if (fs.GetType() == typeof(DirectoryInfo))
                    
                    {
                        dir = new DirectoryInfo(fs.FullName);
                        cursor = 0;
                        writeAll(dir, cursor);
                    }

                    else
                    {
                        StreamReader sr = new StreamReader(fs.FullName);
                        Console.Clear();
                        string s = sr.ReadToEnd();
                        Console.Write(s);
                        Console.ReadKey();
                        writeAll(dir, cursor);
                    }
                    break;

                case ConsoleKey.Backspace:
                    dir = dir.Parent;
                    writeAll(dir, cursor);
                    break;
                case ConsoleKey.Escape:
                    return;
            }
        }
    }
}

