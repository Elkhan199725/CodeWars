using System;

namespace Solution
{
    public class SolutionClass
    {
        public static void Main()
        {
            Console.WriteLine("enter numbe for checking: ");
            int number =(int)Convert.ToInt32(Console.ReadLine());//assigning the value to the 'number'

            //Call the EvenOrOdd method and pass the 'number' variable as an argument
            string result = EvenOrOdd((int)number);
            Console.WriteLine($"the number is {result}");
        }
        public static string EvenOrOdd(int number)
        {
            if(number %2 == 0)
            {
                Console.WriteLine("this is even number");
                return "even";
            }
            else if (number %2 != 0)
            {
                Console.WriteLine("this is odd number");
                return "odd";
            }
            else
            {
                return "invalid";
            }
        }
        
    }
}