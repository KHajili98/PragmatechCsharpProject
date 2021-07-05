using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonForm
{
    /*
     
            1. 
            Person classi yaratmalisiz 
            id, 
            name, 
            surname, 
            birthdate, 
            country , 
            city 
            dizayn elediyiniz formApp de bu propertilere uygun deyerler daxil edilecek ve gosterilecek formatlari
            saxlayan listbox olmalidir , info hissesinde yerlesen btn clik olunan zaman gosterilecek formatlar selectinden
            secilen formata gore Info hissesinde olan label-in textine person-un melumatlari yazilacaq.
            
            qeyd : Delegate istifade edilmelidir.
            
            format selectBox
            
            Name Surname
            Name Surname, Country: Country, 
            Name Surname, Country: Country, City: City,
            Name Surname, Country: Country, City: City, Birthdate : Birthdate
     */
    static class Program
    {
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
