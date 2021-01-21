using System;

namespace ref_vs_out
{
    class Program
    {
        #region "ref" ve "out" Keywordleri
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 30;
            int result = Sum(num1, num2);
            Console.WriteLine(result);
            Console.WriteLine(num1);
            Console.WriteLine("-------");
            Console.WriteLine("SumRef");

            int resultRef = SumRef(ref num1, num2);
            Console.WriteLine(result);
            Console.WriteLine(num1);
            Console.WriteLine("-------");
            Console.WriteLine("SumOut");

            int resultOut = SumOut(out num1, num2);
            Console.WriteLine(resultOut);
            Console.WriteLine(num1);
        }
        static int Sum(int num1, int num2)
        {
            num1 = 30;
            int result = num1 + num2;
            return result;
        }
        // Sum metodu num1 parametresi üzerinde bir değişiklik yapıp toplama işlemine sonra devam etmektedir. Bu metodun içerisinde num1 parametresi 30 değeriyle çalışır ancak;
        //Main metodu içerisinden parametre olarak gönderdiğimiz num1 değişkeninde hiçbir değişiklik olmaz. Bunun nedeni Sum metoduna parametre olarak gönderdiğimiz num1 değişkeninin,
        //int veri tipinde tanımlanmış bir değer tipli değişken olmasıdır. Değer tipli değişkenler bir metoda parametre olarak verildikleri zaman değişkenin kendisi (referansı) değil, o 
        //anki değeri gönderilir. İlgili metottaki işlemler tamamlandıktan sonra return edilen değer, parametrenin yeni değerine göre belirlenir. Yani Main'de 13. satırdaki kodun çıktısı
        //60 olarak görünür. Ancak 14. satırda num1 değerini ekrana yazdırmak istediğimizde sonucu 20 olarak görürüz. Bunun nedeni num1'in değer tipli bir değişken olmasıdır.
        static int SumRef(ref int num1, int num2)
        {
            num1 = 30;
            int result = num1 + num2;
            return result;
        }
        // SumRef metodunda ise parametre olarak int tipte bir değişkenle sanki bir referans tipli değişkenmiş gibi işlem yapmak istediğimizi söylüyoruz. Bu sayede SumRef metodunda num1
        //değişkeni parametre olarak kullanıldıktan sonra, artık Main metodunun içindeki num1 değişkeninin de değeri 30 olacaktır. Yani 17. satırın ekran çıktısı 60, 18. satırın ekran 
        //çıktısı ise 30 olur. Main içerisindeki num1 değişkeni 16. satırdan sonra 30 değerine sahip olur. Bu sonucu ref keywordü sayesinde int veri tipindeki bir değişkenle sanki referans
        //tipli bir değişkenmiş gibi işlem yaparak elde edebiliriz.
        static int SumOut(out int num1, int num2)
        {
            num1 = 40;
            int result = num1 + num2;
            return result;
        }
        // "out" keywordünün "ref" keywordünden kullanım açısından hiçbir farkı yoktur. İkisi de değer tipli değişkenler üzerinde referans tipli değişkenmiş gibi işlem yapmamızı sağlar.
        //SumOut metoduna num1 parametresi gönderildiğinde değeri 30 olarak gelecektir, çünkü SumOut metodu 16. satırdan sonra çağırılmıştır (bkz. Line 39). Ancak bu parametre içerde işleme
        //alındığında değeri 40 olarak set edildiği için 21. satırın ekran çıktısı 70, 22. satırın ekran çıktısı ise 40 olacaktır. SumRef metodu için yazılan bütün açıklamalar SumOut metodu
        //için de geçerlidir.

        #region ref ve out Arasındaki Fark
        // "ref" keywordü kullanırken, kullandığımız değişkeni ilgili metodun içerisine parametre olarak gönderiyoruz, metodun içerisinde bu parametre üzerinde bir değişiklik yapılırsa
        //"İlgili metot çalıştıktan sonra o metodun içerisinde tanımlanmış olan değeri geçerli olacak", demiş oluyoruz. Bu nedenle ref keywordü kullanılırsa, parametre olarak gönderilen
        //değer tipli değişkenin parametre olarak verilebilmesi için, parametre olarak verilmeden önce ilgili metodun çağırıldığı metot içerisinde set edilmiş, yani tanımlanmış olması
        //zorunludur. Kısaca ilgi metoda parametre olarak verilmeden önce değişkene bir değer atanmış olması gerekiyor.

        // "out" keywordünde ise çağırıldığında parametre bekleyen metot, out ile işaretlenmiş olan parametrenin değerini çağırıldığı yere göndereceğini belirtiyor. Yani bu kez ilgili
        //değişkenin değerinin metodun çağırıldığı yerde değil, bizzat o metodun içinde set edilmiş olması gerekiyor.
        #endregion
        #endregion
    }
}
