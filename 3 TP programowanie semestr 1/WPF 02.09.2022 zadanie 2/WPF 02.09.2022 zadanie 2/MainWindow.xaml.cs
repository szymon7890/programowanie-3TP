using System.Windows;
using System.Windows.Controls;

namespace WPF_02._09._2022_zadanie_2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Metoda wywoływana przy zmianie tekstu w polu tekstowym tb_CPU
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Włączenie przycisku btn_CoolDown po zmianie tekstu
            btn_CoolDown.IsEnabled = true;
        }

        // Metoda wywoływana przy zaznaczeniu CheckBox "Limit use"
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            // Ustawienie pola tekstowego tb_memory jako tylko do odczytu
            tb_memory.IsReadOnly = true;
        }

        // Metoda wywoływana przy odznaczeniu CheckBox "Limit use"
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            // Ustawienie pola tekstowego tb_memory jako edytowalnego
            tb_memory.IsReadOnly = false;
        }

        // Metoda wywoływana przy zaznaczeniu CheckBox "Gray"
        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            // Wyświetlenie komunikatu po kliknięciu w CheckBox "Gray"
            MessageBox.Show("clicked");
        }

        // Metoda wywoływana przy odznaczeniu CheckBox "Gray"
        private void CheckBox_Unchecked_1(object sender, RoutedEventArgs e)
        {
            // Dodatkowy kod obsługi odznaczenia CheckBox "Gray"
            // Możesz dodać tutaj dodatkowe instrukcje w razie potrzeby
        }

        // Metoda wywoływana po kliknięciu przycisku "Cool Down"
        private void btn_CoolDown_Click(object sender, RoutedEventArgs e)
        {
            // Ustawienie tekstu w polu tekstowym tb_CPU na "10%"
            tb_CPU.Text = "10%";
        }
    }
}
