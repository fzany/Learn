using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    internal class Logic
    {
        public static void Commander()
        {
            Console.WriteLine("Enter the age");
            int.TryParse(Console.ReadLine(), out int age);
            switch (age)
            {
                case 20:
                    {
                        Console.WriteLine("I am young");
                        break;
                    }
                case 50:
                    {
                        Console.WriteLine("I am prime");
                        break;
                    }
                case 70:
                    {
                        Console.WriteLine("I am old");
                        break;
                    }
            }
        }
    }
}
