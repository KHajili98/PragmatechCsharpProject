using System;

namespace Week4.Task
{
    public static class AgeCalculator
    {

        public static void CalculateYourAge(string birthDay)
        {
            DateTime today = DateTime.Today;
            string[] birthDayArray = new string[3];
            birthDay.Split(',').CopyTo(birthDayArray, 0);
            var age = today.Year - Convert.ToInt32(birthDayArray[2]);
            Console.WriteLine("Sizin yawiniz : " + age);
        }

    }

    }

