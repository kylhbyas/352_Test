using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private int thing;
        public void Setter(string s)
        {
            //thing = s;
            //Console.WriteLine(s);
            s = s.Replace("\n", String.Empty);
            thing = Int32.Parse(s);
        }
        public int Getter()
        {
            return thing;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Random rnd = new Random();
            int num = rnd.Next(10);
            Console.WriteLine(num);

            Program p = new Program();
            string r;
            r = Console.ReadLine();
            p.Setter(r);

            if (p.Getter() == num)
            {
                Console.WriteLine("Congratulations!");
            }else
            {
                Console.WriteLine("Boo :(");
            }

            //Console.WriteLine(p.Getter());
            Console.ReadKey();
        }
    }
}
