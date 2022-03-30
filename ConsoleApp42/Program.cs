using System;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile chcesz wpisać liczb?");
            int rozmiar = int.Parse(Console.ReadLine());
            int[] numbers = new int[rozmiar];
            for (int i = 0; i < numbers.Length; i++) //petla zapelniająca tablice liczbami
            {
                Console.WriteLine("Podaj {0} liczbę", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Elementy tablicy to:");
            for (int i = 0; i < numbers.Length; i++) // petla wypisujaca elementy tablicy
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int max = numbers[0];                     ////////// Wartość i numer pozycji największego elementu
            int pozycja = 0;
            for (int i = 1; i < numbers.Length; i++) // nie trzeba juz porownywac pierwszego elemntu, wiec zaczynam od 1
            {
                if (numbers[i]> max)
                {
                    max = numbers[i];
                    pozycja = i;
                }
            }
            Console.WriteLine("Największa wartość w tablicy to: {0}, znajduje się ona na pozycji {1}", max, pozycja+1);
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int min = numbers[0];                     ////////// Wartość i numer pozycji najmniejszegoo elementu
            int pozycja2 = 0;
            for (int i = 1; i < numbers.Length; i++) // nie trzeba juz porownywac pierwszego elemntu, wiec zaczynam od 1
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    pozycja2 = i;
                }
            }
            Console.WriteLine("Najmniejsza wartość w tablicy to: {0}, znajduje się ona na pozycji {1}", min, pozycja2 +1);
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int suma = 0;
            double srednia;
            for (int i = 0; i < numbers.Length; i++)
            {
                suma += numbers[i];
            }
            srednia = (double)suma / numbers.Length;
            Console.WriteLine("Średnia to: {0}", srednia);
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int zlicz = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]>0)
                {
                    zlicz++;
                }
            }
            Console.WriteLine("W tej tablicy występuje {0} dodatnich elementów", zlicz);
            Console.ReadKey();
        }
    }
}
