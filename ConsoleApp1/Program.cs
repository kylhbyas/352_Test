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
            thing = Int32.Parse(guess);
        }
        public int Getter()
        {
            return thing;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lower Bound, inclusive:");
            string LB = Console.ReadLine();
            int lowerBound = Int32.Parse(LB);

            Console.WriteLine("Upper Bound, exclusive:");
            string UB = Console.ReadLine();
            int upperBound = Int32.Parse(UB);

            Console.WriteLine("I am thinking of a number between " + lowerBound + " and " + upperBound);
            Random rnd = new Random();
            int num = rnd.Next(lowerBound, upperBound);
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
            Console.WriteLine("# of guesses = " + counter);
            Console.ReadKey();
        }
    }
}
