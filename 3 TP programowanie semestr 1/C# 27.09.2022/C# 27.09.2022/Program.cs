using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__27._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Wypisuje prośbę o podanie imienia użytkownika.
            Console.WriteLine("Podaj imię");
            // Odczytuje wprowadzone przez użytkownika imię.
            string imie = Console.ReadLine();
            // Wypisuje prośbę o podanie nazwiska użytkownika.
            Console.WriteLine("Podaj nazwisko");
            // Odczytuje wprowadzone przez użytkownika nazwisko.
            string nazwisko = Console.ReadLine();

            // Wyświetla na konsoli imię i nazwisko wprowadzone przez użytkownika.
            Console.WriteLine($"Imię: {imie} \nNazwisko: {nazwisko}");
            // Czeka na wciśnięcie klawisza Enter przez użytkownika przed kontynuacją.
            Console.ReadLine();

            // Sprawdza, czy plik o nazwie "file.txt" istnieje.
            if (File.Exists("file.txt"))
            {
                // Jeśli plik istnieje, wyświetla odpowiedni komunikat na konsoli.
                Console.WriteLine("Plik istnieje!");
            }

            // Tworzy obiekt StreamWriter, który umożliwia zapis do pliku "file.txt".
            // Kod w bloku 'using' zapewnia automatyczne zamknięcie strumienia po zakończeniu jego użycia.
            using (var file = new StreamWriter("file.txt", false, System.Text.Encoding.UTF8))
            {
                // Zapisuje linię tekstu do pliku.
                file.WriteLine("Coś tam do zapisania");
                // Kontynuuje zapis, nie przechodząc do nowej linii.
                file.Write("tekst do zapisania");
            }
        }
    }
}