using System;

namespace _12.TradeCommission
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());
            double comission = 0;
            if (town == "Sofia")
            {
                if (price >= 0 && price <= 500)
                {
                    comission = price * 0.05;
                }
                else if (price > 500 && price <= 1000)
                {
                    comission = price * 0.07;
                }
                else if (price > 1000 && price <= 10000)
                {
                    comission = price * 0.08;
                }
                else if (price > 10000)
                {
                    comission = price * 0.12;
                }
               
            }
            else if (town == "Varna")
            {
                if (price >= 0 && price <= 500)
                {
                    comission = price * 0.045;
                }
                else if (price > 500 && price <= 1000)
                {
                    comission = price * 0.075;
                }
                else if (price > 1000 && price <= 10000)
                {
                    comission = price * 0.10;
                }
                else if (price > 10000)
                {
                    comission = price * 0.13;
                }
               


            }
            else if (town == "Plovdiv")
                if (price >= 0 && price <= 500)
                {
                    comission = price * 0.055;
                }
                else if (price > 500 && price <= 1000)
                {
                    comission = price * 0.08;
                }
                else if (price > 1000 && price <= 10000)
                {
                    comission = price * 0.12;
                }
                else if (price > 10000)
                {
                    comission = price * 0.145;
                }
                
            if (comission != 0)
            {
                Console.WriteLine($"{comission:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
