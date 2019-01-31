using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current date is: " + DateTime.Today.ToString("yyyy/MM/dd"));

            DateTime end = new DateTime(2019, 1, 1);
            DateTime start = DateTime.Today;
            Console.WriteLine("Number of days elapsed since start of the year: " + (start.Date - end.Date).Days);

            //Loops through the years to find a leap year. 2500 is chosen for just to have the max limit for the loop.
            for (var year = 2019; year <= 2500; year++)
            {
                if (DateTime.IsLeapYear(year))
                {
                    DateTime weekday = new DateTime(year, 1, 1);
                    int weekdayNumber = (int)weekday.DayOfWeek;

                    //Checks if the weekday number matches with Tuesday as the 2nd day of the week.
                    if (weekdayNumber == 2){
                        Console.WriteLine("Next leap year that starts with Tuesday is: " + year);
                        break;
                    }
                }
            }

            EmailValidator email = new EmailValidator();
            email.emailValidator();

            DigitsCalculator sum = new DigitsCalculator();
            sum.calculateSumOfDigits();
        }
    }
}
