using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private string thing;
        public void Setter(string s)
        {
            thing = s;
        }
        public string Getter()
        {
            return thing;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program p = new Program();
            string r;
            r = Console.ReadLine();

            p.Setter(r);
            Console.WriteLine(p.Getter());
            Console.ReadKey();
        }
    }
}
