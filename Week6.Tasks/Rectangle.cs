using System;
using System.Threading;

namespace Week6.Tasks
{
    public class Rectangle
    {
        private double _uzunluq;

        public double Uzunluq
        {
            get { return _uzunluq; }
            set { _uzunluq = value; }
        }

        private double _en;

        public double En
        {
            get { return _en; }
            set { _en = value; }
        }



        public static double SetTeref(string teref)
        {
            double _teref;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Zehmet olmasa " + teref + " daxil edin : ");
                var inputUzunluq = Console.ReadLine();

                if (string.IsNullOrEmpty(inputUzunluq) || string.IsNullOrWhiteSpace(inputUzunluq) || !Double.TryParse(inputUzunluq, out _teref))
                {
                    Console.WriteLine("!!!!!!!!!!        " + teref + " duzgun daxil edin      !!!!!!!!!!");
                    Thread.Sleep(3000);
                    continue;
                }
                else
                {
                    _teref = Convert.ToDouble(inputUzunluq);
                    Console.Clear();
                    break;
                }
            }
            return _teref;
        }
        public double CalculateArea()
        {
            if (Uzunluq < 0) Uzunluq = 0;
            if (En < 0) En = 0;
            return Uzunluq * En;
        }


    }
}
