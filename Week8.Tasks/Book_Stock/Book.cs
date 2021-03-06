using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Stock
{
   public  class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string StockCount { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public static List<Book> books = new()
        {
            new Book
            {
                Id = 1,
                Name = "Qızılbaşlar",
                Author = "Əlisa Nicat",
                Category = "Tarix",
                StockCount = "22",
                Description = @"“Qızılbaşlar” romanı Azərbaycan tarixinin ən qüdrətli siması olan
                                Şah İsmayıl Xətainin və Səfəvilər dövlətinin ən parlaq dövrünün təsvirinə
                                həsr olunmuş ilk böyük nəsr əsəridir. 1960-cı illərin əvvəllərində yazılan
                                bu roman o dövrün məşhur xalq yazıçılarının səyləri nəticəsində yalnız 1983-cü ildə
                                işıq üzü görüb. O vaxtdan Azərbaycan və Türkiyədə bir neçə dəfə nəşr olunan roman
                                ümumxalq məhəbbəti qazanıb.",
                Image = @"C:\Users\shaba\source\repos\PragmatechCsharpProject\Week8.Tasks\Book_Stock\qizilbawlar.jpeg"

            },
            new Book
            {
                Id = 2,
                Author = "Ədalət Tahirzadə",
                Category = "Tarix",
                Name = "Meydan",
                StockCount = "11",
                Description = @"“Bu ki­tabda Azərbaycanda 1988-ci ilin 19 fevralından 1992-ci ilin 16 iyununadək
                                baş vermiş irili-xırdalı bütün önəmli hadisələr (ermənilərlə Qarabağ uğründa savaş,
                                Qorbaçovun Qarabağıermənilərə vermək üçün siyasi oyunları, Azərbaycan Xalq Cəb­həsinin 
                                yaranması və xalqa rəhbərliyi, respublika başçılarının qorxaqlığı, yaltaqlığı və fərsizliyi,
                                hakimiyyət davaları, xalqımızın azadlıq və müstəqillik uğrunda ölüm-dirim mübarizəsi, 20 Yanvar,
                                Xocalı soyqırımı, Moskvanın Qarabağı Azərbaycan tabeli­yin­dən necə çıxarması…) öz əksini tapıb.",
                Image = @"C:\Users\shaba\source\repos\PragmatechCsharpProject\Week8.Tasks\Book_Stock\meydan.png"

            },
            new Book
            {
                Id = 3,
                Author = "İskəndər Pala",
                Category = "Roman",
                Name = "Od",
                StockCount = "5",
                Description = @"İsgəndər Pala (1958) Uşakda doğulub, İstanbul Universitetinin Ədəbiyyat fakültəsini bitirib (1979),
                                elmlər doktoru, professordur. Türk Silahlı Qüvvələrinin tədris qurumlarında və Uşak Universitetində 
                                müəllimlik edib. İstanbul Kültür Universitetində elmi-pedaqoji fəaliyyətini davam etdirməklə bərabər, 
                                Mədəniyyət və Turizm nazirinin, həm də İstanbul Böyükşəhər Bələdiyyə başçısının müşaviri, Türkiyə Dil 
                                və Tarix Qurumu İdarə Heyətinin üzvüdür. Bir çox nüfuzlu mükafatlar sahibidir.",
                Image = @"C:\Users\shaba\source\repos\PragmatechCsharpProject\Week8.Tasks\Book_Stock\od.png"

            },
        };

        public override string ToString()
        {

            return Name;
        }
    }
}
