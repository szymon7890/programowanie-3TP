using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // Importuje przestrzeń nazw System.Data, która zawiera klasy do obsługi danych.
using System.Diagnostics; // Importuje przestrzeń nazw System.Diagnostics, która zawiera narzędzia do pomiaru wydajności.

namespace C__03._11._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int colCounter = 1; // Inicjalizuje zmienną colCounter na 1, która będzie używana do śledzenia kolumn.
            string txt = " "; // Inicjalizuje zmienną txt jako pustą, która będzie przechowywać wynikową tablicę.
            int rowCounter = 1; // Inicjalizuje zmienną rowCounter na 1, która będzie używana do śledzenia wierszy.

            while (colCounter < 10) // Pętla while będzie kontynuowana, dopóki wartość colCounter jest mniejsza niż 10.
            {
                while (rowCounter < 10) // Pętla while będzie kontynuowana, dopóki wartość rowCounter jest mniejsza niż 10.
                {
                    txt = txt + rowCounter + "x" + colCounter + "=" + colCounter * rowCounter + " "; // Konkatenacja do zmiennej txt ciągu znaków zawierającego wynik mnożenia w postaci "rowCounter x colCounter = wynik ".
                    rowCounter++; // Inkrementacja rowCounter, aby przejść do następnego wiersza.
                }
                txt = txt + '\n'; // Dodanie nowej linii do zmiennej txt po zakończeniu kolumn.
                colCounter++; // Inkrementacja colCounter, aby przejść do następnej kolumny.
                rowCounter = 1; // Resetowanie rowCounter do 1, aby rozpocząć od pierwszego wiersza.
            }

            Console.WriteLine(txt); // Wyświetlenie wynikowego tekstu na konsoli.
            Console.ReadLine(); // Oczekiwanie na naciśnięcie klawisza Enter przez użytkownika przed zakończeniem programu.
        }
    }
}
