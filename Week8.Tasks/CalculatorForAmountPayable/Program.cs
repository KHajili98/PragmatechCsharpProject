using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForAmountPayable
{
    /*
    - istifadeci terefinden productin adi ve qiymet daxil edilir, daxil edilen bu productlar
    - listBoxda adi ve qiymeti olaraq gosterilmelidir, butun mehsullarda 18 % edv var ve bundan elave
    - Telebe ve ya pensiyaner endirimi istifadeci terefinden "secilerse" umumi meblege samil edilecek.
    - Hesabla button-a klik olunan zaman asagdaki textbox-da total cixmalidir
    - Temizle button-a klik olunan zaman ise elementlerdeki datalar temizlenecek.
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
            Application.Run(new CalculatorForAmountPayable());
        }
    }
}
