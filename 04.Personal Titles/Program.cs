using System;

namespace _04.Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            if (age >=16)
            {
                if (sex == "m")
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }
            else
            {
                if (sex=="f")
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
        }
    }
}
