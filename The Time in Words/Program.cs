using System;

namespace The_Time_in_Words
{
    class Program
    {
        readonly static string[] numbers = {
                "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",  "eleven", "twelve", "thirteen",
                "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty", "twenty one", "twenty two",
                "twenty three", "twenty four", "twenty five", "twenty six", "twenty seven", "twenty eight", "twenty nine" };

        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());
            var textTime = string.Empty;

            if (minute < 30)
            {
                if (minute.Equals(15))
                {
                    textTime = "quarter past " + GetNumberString(hour);
                }
                else
                {
                    //0 to 29 - 15
                    textTime = minute.Equals(0)
                        ? GetNumberString(hour) + " o' clock"
                        : GetNumberString(minute) + (minute.Equals(1) ? " minute" : " minutes") + " past " +
                          GetNumberString(hour);
                }

            }
            else if (minute > 30)
            {
                //Regresive count twenty to six = 5:40 -> 60-40 = 20
                minute = 60 - minute;
                //31-59
                textTime = minute.Equals(15)
                    ? "quarter to " + GetNumberString(hour + 1)
                    : GetNumberString(minute) + " minutes to " + GetNumberString(hour + 1);
            }
            else
            {
                //30
                textTime = "half past " + GetNumberString(hour);
            }

            Console.WriteLine(textTime);
        }

        static string GetNumberString(int number)
        {
            return numbers[number - 1];
        }

    }
}
