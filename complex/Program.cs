using ComplexNum;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNum
{
    public class Program
    {
        public static ConsoleKeyInfo btn;
        static void Main(string[] args)
        {
            
                f1();
                f2();

        }

            public static void f2()
        {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream("test.txt", FileMode.Open, FileAccess.Read);

                try
                {
                    Complex s = bf.Deserialize(fs) as Complex;
                    Console.Write(s);

                    Console.ReadKey();
                }
                catch
                {
                    Console.Write("deserialize error");
                }
                finally
                {
                    fs.Close();
                }
            }

            public static void f1()
        {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            Complex s = new Complex ();
                Console.WriteLine(s.ToString());

                try
                {
                    bf.Serialize(fs, s);
                }
                catch
                {
                    Console.Write("serialize error");
                }
                finally
                {
                    fs.Close();
                }

            

        

            Complex a = new Complex();
            Complex b = new Complex();
            a.X = int.Parse(Console.ReadLine());
            a.Y = int.Parse(Console.ReadLine());

            b.X = int.Parse(Console.ReadLine());
            b.Y = int.Parse(Console.ReadLine());
            Complex c = a * b;


            Console.Write(c);

            Console.ReadKey();
        }

    }
}