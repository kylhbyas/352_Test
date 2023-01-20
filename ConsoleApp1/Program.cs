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
        public void Setter(string guess)
        {
            //thing = s;
            //Console.WriteLine(s);
            thing = Int32.Parse(guess);
        }
        public int Getter()
        {
            return thing;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Console.WriteLine("I am thinking of a number between 0 and 100");
            Random rnd = new Random();
            int num = rnd.Next(100);
            Console.WriteLine(num);

            Program p = new Program();
            string guess = Console.ReadLine();
            p.Setter(guess);

            int counter = 1;

            while (p.Getter() != num)
            {
                if (p.Getter() < num)
                {
                    Console.WriteLine("Too Low");
                }
                else if (p.Getter() > num)
                {
                    Console.WriteLine("Too High");
                }
                else if (p.Getter() == num)
                {
                    Console.WriteLine("Congratulations!");
                }
                counter++;
                Console.WriteLine("Guess again:");
                guess = Console.ReadLine();
                p.Setter(guess);
            }
            Console.WriteLine("# of guesses = "+counter);
            //Console.WriteLine(p.Getter());
            Console.ReadKey();
        }
    }
}
