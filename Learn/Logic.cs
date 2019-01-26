using System;

namespace Learn
{
    internal class Logic
    {
        public static void Commander()
        {
            // Program to Print out grades of an Inputed score.
            Console.WriteLine("Enter score");
            int.TryParse(Console.ReadLine(), out int score);
            //switch (score)
            //{
            //    case :
            //        {
            //            Console.WriteLine("I am young");
            //            break;
            //        }
            //    case 50:
            //        {
            //            Console.WriteLine("I am prime");
            //            break;
            //        }
            //    case 70:
            //        {
            //            Console.WriteLine("I am old");
            //            break;
            //        }
            //}
            if (score <=39)
            {
                Console.WriteLine("Result - F");
            }

            else if (score <= 49)
            {
                Console.WriteLine(" Result - E");
            }
            else if (score <= 59)
            {
                Console.WriteLine("Result - C");
            }
            else if (score <= 69)
            {
                Console.WriteLine("Result -   B");
            }
            else if (score <= 79)
            {
                Console.WriteLine("Result -   A");
            }

            Console.WriteLine(score);




        }
    }
}
