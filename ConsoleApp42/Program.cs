using System;

class Program
{
    static void Main()
    {
        Console.Write("Adın nədir? ");
        string ad = Console.ReadLine();

        Console.Write($"Salam, {ad}! İndi isə sənin yaşını sehrli şəkildə tapacam. Doğulduğun ili daxil et: ");
        int dogumYili = Convert.ToInt32(Console.ReadLine());

        int cariIl = DateTime.Now.Year;
        int yas = cariIl - dogumYili;

        Console.WriteLine($"\nBax, bildim! Sənin təxminən {yas} yaşın var. Kompüterlər heç vaxt yanılmır! 😉");
    }
}