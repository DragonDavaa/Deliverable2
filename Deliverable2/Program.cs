// Author: Davaanyam Baljinnyam
// Date 1/19/2023
//Description: Deliverable2

using System; //calling system library

namespace Deliverable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number grade you expect in ISM 4300: ");
            try
            {
                decimal grade = decimal.Parse(Console.ReadLine());
                string letter;

                if ((grade > 90) && (grade < 100))
                {
                    Console.WriteLine("Your expected letter grade for ISM 4300 is A ");
                    Console.ReadKey(true);
                }
                else if ((grade > 80) && (grade < 89))
                {
                    Console.WriteLine("Your expected letter grade for ISM 4300 is B ");
                    Console.ReadKey(true);
                }
                else if ((grade > 70) && (grade < 79))
                {
                    Console.WriteLine("Your expected letter grade for ISM 4300 is C ");
                    Console.ReadKey(true);
                }
                else if ((grade > 60) && (grade < 69))
                {
                    Console.WriteLine("Your expected letter grade for ISM 4300 is D ");
                    Console.ReadKey(true);
                }
                else if ((grade > 0) && (grade < 59))
                {
                    Console.WriteLine("Your expected letter grade for ISM 4300 is F ");
                    Console.ReadKey(true);
                }
                else if (grade > 100)
                {
                    Console.WriteLine("The grade you have entered is higher than 100");
                }
            }
            catch
            {
                Console.WriteLine("The data type for grade is not integer");
            }
        }
    }
}