using System;

namespace beans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Bean store sim";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("The beans are 500$ \n Please insert cash");

            int cash = Convert.ToInt32(Console.ReadLine());
            if (cash == 500)
            {
                Console.WriteLine("Ok you got some beans happy now?");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                
            }else if (cash <= 500)
            {
                Console.WriteLine("Get some more money you scrub");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }else if (cash > 500)
            {
                double beans3 = cash - 500;
                Console.WriteLine("You had more than enough for your beans. \n Heres your change " + beans3);
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}