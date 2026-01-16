// See https://aka.ms/new-console-template for more information
using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            string operation = "";

            Console.WriteLine("Basit Hesap Makinesi");
            Console.WriteLine("--------------------");

            Console.Write("İlk sayıyı giriniz: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Yapılacak işlemi (+, -, *, /) giriniz: ");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Sonuç: {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"Sonuç: {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"Sonuç: {num1 * num2}");
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Sonuç: {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Sıfıra bölme hatası!");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem.");
                    break;
            }

            Console.WriteLine("Hesaplama tamamlandı.");
            Console.ReadKey();
        }
    }
}

