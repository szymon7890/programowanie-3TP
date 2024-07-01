using System;
using System.IO;

namespace C__01._10._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text; // Deklaracja zmiennej text, która będzie przechowywać wprowadzony przez użytkownika tekst.
            string text1; // Deklaracja zmiennej text1, która zostanie użyta do zapisania wprowadzonego tekstu.
            Console.Write("Imie:"); // Wyświetlenie komunikatu proszącego użytkownika o wprowadzenie imienia.
            text = Console.ReadLine().ToString(); // Pobranie tekstu wprowadzonego przez użytkownika i przypisanie go do zmiennej text.
            text1 = text; // Przypisanie zawartości zmiennej text do zmiennej text1.
            string path = AppDomain.CurrentDomain.BaseDirectory + @"writetext.txt"; // Utworzenie ścieżki do pliku tekstowego, który zostanie utworzony lub odczytany.
                                                                                    // AppDomain.CurrentDomain.BaseDirectory zwraca ścieżkę do katalogu, w którym znajduje się plik wykonywalny aplikacji.
            if (!File.Exists(path)) // Sprawdzenie, czy plik o podanej ścieżce istnieje.
            {
                using (StreamWriter sw = File.CreateText(path)) // Utworzenie nowego pliku tekstowego do zapisu.
                {
                    sw.WriteLine(text1); // Zapisanie wprowadzonego tekstu do pliku.
                } // Koniec bloku using, w którym zostanie automatycznie wywołana metoda Dispose na obiekcie StreamWriter, aby zwolnić zasoby.
            }
            string line; // Deklaracja zmiennej line, która będzie przechowywać odczytane linie z pliku.
            StreamReader sr = new StreamReader(path); // Utworzenie obiektu StreamReader do odczytu danych z pliku.
            while ((line = sr.ReadLine()) != null) // Odczytaj każdą linię z pliku, dopóki nie zostanie osiągnięty jego koniec.
            {
                Console.WriteLine(line); // Wyświetl odczytaną linię na konsoli.
            }

            Console.ReadKey(); // Oczekiwanie na naciśnięcie dowolnego klawisza przez użytkownika przed zakończeniem programu.
        }
    }
}
