using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01App
{
    public class DigitsCalculator
    {
        public void calculateSumOfDigits()
        {
            var sum = 0;
            Console.WriteLine("Enter a positive integer: ");
            var input = Console.ReadLine();

            int parsedInput;

            //Checks whether the input is an integer
            if (int.TryParse(input, out parsedInput))
            {
                if(parsedInput < 0)
                {
                    Console.WriteLine("The entered number is negative");
                }
                else
                {
                    //Parses string input to char array and then char array to int array.
                    int[] numbers = input.ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
                    var sum1 = numbers.Count();

                    for (var i = 0; i < sum1; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine($"The sum is: {sum}");
                }
            }
            else
            {
                Console.WriteLine("The input value is incorrect!");
            }
        }
    }
}
