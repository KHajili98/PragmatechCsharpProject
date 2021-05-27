using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Order_System
{
    static class Program
    {

        /*
        - istifadeci terefinden sifaris verenin adi, soyadi , nomresi , adresi ,
        - pizzanin olcusu(comboBox) ve sayi, terkibi , icecek(comboBox) ve sayi   daxil edilir,
        - Sifaris Al : kilik olunan zaman asagdaki groupBox Icerisinde listBoxLarda daxil edilen melumatlar ve umumi qiymet gosterilecek.
        - Temizle: data daxil edilen elementlerdeki datalar silinir.
        - Sifarisleri sil : Asagdaki lisboxlarda gosterilen butun sifarisler silinir.
        - Pizza olcu : (Boyuk,Orta,Kicik) ola biler qiymetleri ferqli olacaq,
        - Terkibi (checkBox vasitesi ile evvelceden sistemde olan mehsullara uygun ozu secir): Example - “Mozarella” pendiri, vetçina, göbələk, italyan otları, zeytun yağı 
        - Qeyd : bir form dizayn ederken bir biri ile elaqeli elementleri bir groupbox iscerisinde yerlesdirin. 

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
