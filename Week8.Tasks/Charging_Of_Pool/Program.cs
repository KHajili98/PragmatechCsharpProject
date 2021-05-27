using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charging_Of_Pool
{
    static class Program
    {
        /*
        - istifadeci terefinden hovuzun derinliyi, uzunlugu, eni daxil edilir(numericUpDown),
        - buna uygun hovuzun hecmini hesablayib gostermelisiz,
        - ikinci groupBox icerisinde ise iki eded su kraninin deqiqede nece kub/metr doldurdugu daxil edilir(numericUpDown) ,
        - ilk once hovuzun hecmi hesablanan groupBox active olmalidir, yeni su kranlari ancaq hovuzun hecmi hesablandiqdan sonra aktiv olacaq
        - ikinci group box icerisinde hesabla-ya klik olunan zaman 2 su kranin hovuzu neqeder vaxta doldurdugunu gostermeliyik.
        */


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
