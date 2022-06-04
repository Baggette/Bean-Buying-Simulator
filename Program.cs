using System;

namespace beans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Bean store sim";

            Console.WriteLine("The beans are 500$ \n Please insert cash");

            int cash = Convert.ToInt32(Console.ReadLine());

            //checking if they have enough money for beans
            if (cash == 500)
            {
                Console.WriteLine("Ok you got some beans.");      
            }else if (cash <= 500)
            { 
                Console.WriteLine("Get some more money you scrub");
            }else if (cash > 500)
            {
                double beans3 = cash - 500;
                Console.WriteLine("You had more than enough for your beans. \n Heres your change " + beans3 + "$");
            }
            Console.WriteLine("Press any key to exit...");
            if(Console.ReadLine() == "beans")
            {
                Console.WriteLine("Insert easter egg here. \n Bean sim created by Baggette \n I would Like to give a Special thanks to the \n one \n the \n only \n BEANS!!!!!! \n Press any key to exit (fr this time)...");
            }
            Console.ReadKey();
        }   
    }
}