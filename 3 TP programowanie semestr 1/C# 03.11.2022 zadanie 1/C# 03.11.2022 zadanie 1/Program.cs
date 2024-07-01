using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__03._11._2022
{
    class Program
    {
        static void Main()
        {
            double miles, kilometers;

            // Pobieranie od użytkownika wartości w milach
            Console.Write("Podaj odległość w milach: ");
            miles = Convert.ToDouble(Console.ReadLine());

            // Konwersja mil na kilometry
            kilometers = miles * 1.60934;

            // Wyświetlenie wyniku
            Console.WriteLine("{0} mil to {1} kilometrów.", miles, kilometers);
        }
    }
}
