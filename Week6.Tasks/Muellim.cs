using System;

namespace Week6.Tasks
{
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

        public string Status()
        {
            int duration = IslemeTarixi.Year - DogumTarixi.Year;

            if (duration > 23)
            {
                IslemeStatusu =  "!!! Tebrikler !!! Isleye bilersiz";
            }
            else
            {
                IslemeStatusu = "!!! BAGIWLAYIN !!! Isleye BILMEZSIZ";
            }
            return IslemeStatusu;
        }

        public Muellim()
        {
            id = IdGenerator();
        }

    }
}
