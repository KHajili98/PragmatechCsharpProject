using System;
using System.Collections.Generic;

namespace Week6.Tasks
{   /// <summary>
    /// Muellim ucun yaradilmiw class
    /// </summary>
    public class Muellim
    {

        public string  Ad { get; set; }
        public string  Soyad { get; set; }
        public string Vezife { get; set; } = "Teacher";
        public string IslediyiYer { get; set; }
        public DateTime DogumTarixi { get; set; } 
        public DateTime IslemeTarixi { get; set; }

        private string IslemeStatusu;

        public int id { get; }
        
        private int IdGenerator()
        {
            Random rnd = new Random();
            return rnd.Next(1, 100);
        }

        public Muellim()
        {
            id = IdGenerator();
        }
        /// <summary>
        /// Muellimin iwleye bilme huququ haqda yoxlama emeliyyati
        /// </summary>
        public string Status()
        {
            int duration = IslemeTarixi.Year - DogumTarixi.Year;

            if (duration > 23)
            {
                IslemeStatusu =  "!!! Tebrikler !!! Isleye bilersiz";
            }
            else
            {
                IslemeStatusu = "!!! BAGIWLAYIN !!! Isleye BILMEZSIZ. Yawiniz 23den cox olmalidir";
            }
            return IslemeStatusu;
        }


        /// <summary>
        /// Static wekilde muellimlerden ibaret listin hazirlanmasi
        /// </summary>
        public static List<Muellim>  MuellimlerUcunList()
        {
            Random randomDogumIl = new Random();

            List<Muellim> muellimler = new List<Muellim>();


            muellimler.Add(
            new Muellim()
            {
                Ad = "eli",
                Soyad = "Hajili",
                IslediyiYer = "adnsu",
                Vezife = "Mech",
                DogumTarixi = DateTime.Now.AddYears(-randomDogumIl.Next(15, 50)),
                IslemeTarixi = DateTime.Now
            });

            muellimler.Add(
            new Muellim()
            {
                Ad = "veli",
                Soyad = "Hajili",
                IslediyiYer = "adpu",
                Vezife = "AZ",
                DogumTarixi = DateTime.Now.AddYears(-randomDogumIl.Next(15, 50)),
                IslemeTarixi = DateTime.Now
            });

            muellimler.Add(
            new Muellim()
            {
                Ad = "Kamran",
                Soyad = "Hajili",
                IslediyiYer = "atu",
                DogumTarixi = DateTime.Now.AddYears(-randomDogumIl.Next(15, 50)),
                IslemeTarixi = DateTime.Now
            });


            return muellimler;
        }

    }
}
