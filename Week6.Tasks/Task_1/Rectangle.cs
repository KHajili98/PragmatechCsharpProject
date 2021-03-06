using System;
using System.Threading;

namespace Week6.Tasks
{
    public class Rectangle
    {
        
        private double _uzunluq;
        /// <summary>
        /// duzbucaqlinin uzunlugu.
        /// </summary>
        public double Uzunluq
        {
            get { return _uzunluq; }
            set {
                if(value < 0)
                {
                    _uzunluq = 0;
                }
                else
                {
                    _uzunluq = value;
                }
            }
        }

        private double _en;
        /// <summary>
        /// duzbucaqlinin eni.
        /// </summary>
        public double En
        {
            get { return _en; }
            set { 
                if (value < 0)
                {
                    _en = 0;
                }
                else
                {
                    _en = value;
                }
            }
        }


        /// <summary>
        /// consoledan duzbucaqlinin tereflerini daxil etmek ucun funksiya.
        /// </summary>
        public static double SetTeref(string teref)
        {
            double _teref;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Zehmet olmasa " + teref + " daxil edin. Menfi deyer daxil edilerse avtomatik 0 kimi qeyd olunacaqdir : ");
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


        /// <summary>
        /// duzbucaqlinin sahesinin hesablanmasi.
        /// </summary>
        public double CalculateArea()
        {
            return Uzunluq * En;
        }


    }
}
