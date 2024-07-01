using System; // Importuje przestrzeń nazw System, która zawiera podstawowe typy danych i klasy.

using System.Windows; // Importuje przestrzeń nazw System.Windows, która zawiera klasy i interfejsy potrzebne do tworzenia aplikacji okienkowych.
using System.Windows.Controls; // Importuje przestrzeń nazw System.Windows.Controls, która zawiera klasy kontrolek, takich jak przyciski.

namespace MyCalculatorv1 // Określa przestrzeń nazw, w której znajduje się klasa MainWindow.
{
    public partial class MainWindow : Window // Deklaruje klasę MainWindow, dziedziczącą po klasie Window.
    {
        public MainWindow() // Konstruktor klasy MainWindow.
        {
            InitializeComponent(); // Inicjalizuje komponenty interfejsu użytkownika.
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // Obsługuje zdarzenie kliknięcia przycisku.
        {
            Button b = (Button)sender; // Przypisuje zmiennej b obiekt przycisku, który został kliknięty.
            tb.Text += b.Content.ToString(); // Dodaje zawartość przycisku do kontrolki TextBox.
        }

        private void Result_click(object sender, RoutedEventArgs e) // Obsługuje zdarzenie kliknięcia przycisku "=".
        {
            try // Rozpoczyna blok kodu, który może generować wyjątki.
            {
                result(); // Wywołuje metodę result().
            }
            catch (Exception exc) // Obsługuje wyjątki, jeśli wystąpią.
            {
                tb.Text = "Error!"; // Wyświetla komunikat o błędzie w kontrolce TextBox.
            }
        }

        private void result() // Deklaruje metodę result(), która przetwarza wprowadzone działanie i wyświetla wynik.
        {
            String op; // Deklaruje zmienną op przechowującą operator działania.
            int iOp = 0; // Inicjalizuje zmienną iOp, która przechowuje indeks operatora w tekście.
            if (tb.Text.Contains("+")) // Sprawdza, czy tekst zawiera znak "+".
            {
                iOp = tb.Text.IndexOf("+"); // Pobiera indeks znaku "+" w tekście.
            }
            else if (tb.Text.Contains("-")) // Sprawdza, czy tekst zawiera znak "-".
            {
                iOp = tb.Text.IndexOf("-"); // Pobiera indeks znaku "-" w tekście.
            }
            else if (tb.Text.Contains("*")) // Sprawdza, czy tekst zawiera znak "*".
            {
                iOp = tb.Text.IndexOf("*"); // Pobiera indeks znaku "*" w tekście.
            }
            else if (tb.Text.Contains("/")) // Sprawdza, czy tekst zawiera znak "/".
            {
                iOp = tb.Text.IndexOf("/"); // Pobiera indeks znaku "/" w tekście.
            }
            else
            {
                //error    
            }

            op = tb.Text.Substring(iOp, 1); // Pobiera operator z tekstu na podstawie jego indeksu.
            double op1 = Convert.ToDouble(tb.Text.Substring(0, iOp)); // Pobiera pierwszą liczbę z tekstu i konwertuje ją na double.
            double op2 = Convert.ToDouble(tb.Text.Substring(iOp + 1, tb.Text.Length - iOp - 1)); // Pobiera drugą liczbę z tekstu i konwertuje ją na double.

            if (op == "+") // Sprawdza, czy operator to "+".
            {
                tb.Text += "=" + (op1 + op2); // Dodaje do tekstu wynik dodawania.
            }
            else if (op == "-") // Sprawdza, czy operator to "-".
            {
                tb.Text += "=" + (op1 - op2); // Dodaje do tekstu wynik odejmowania.
            }
            else if (op == "*") // Sprawdza, czy operator to "*".
            {
                tb.Text += "=" + (op1 * op2); // Dodaje do tekstu wynik mnożenia.
            }
            else
            {
                tb.Text += "=" + (op1 / op2); // Dodaje do tekstu wynik dzielenia.
            }
        }

        private void Off_Click_1(object sender, RoutedEventArgs e) // Obsługuje zdarzenie kliknięcia przycisku "Wyłącz".
        {
            Application.Current.Shutdown(); // Wyłącza aplikację.
        }

        private void Del_Click(object sender, RoutedEventArgs e) // Obsługuje zdarzenie kliknięcia przycisku "Usuń".
        {
            tb.Text = ""; // Czyści zawartość kontrolki TextBox.
        }

        private void R_Click(object sender, RoutedEventArgs e) // Obsługuje zdarzenie kliknięcia przycisku "Cofnij".
        {
            if (tb.Text.Length > 0) // Sprawdza, czy tekst w kontrolce TextBox ma długość większą niż 0.
            {
                tb.Text = tb.Text.Substring(0, tb.Text.Length - 1); // Usuwa ostatni znak z tekstu w kontrolce TextBox.
            }
        }
    }
}
