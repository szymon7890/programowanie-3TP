#include <iostream> // Dodaje bibliotekę do wejścia/wyjścia
using namespace std; // Używa przestrzeni nazw std, aby można było korzystać z nazw w std bez prefiksu

int funkcja1(){ // Definiuje funkcję funkcja1, która zwraca wartość typu int
    return 0; // Funkcja zwraca wartość 0
}

int main() // Główna funkcja programu
{
    int i=1; // Deklaruje i inicjalizuje zmienną typu int o nazwie i
    char c='h'; // Deklaruje i inicjalizuje zmienną typu char o nazwie c
    string s=" ppp "; // Deklaruje i inicjalizuje zmienną typu string o nazwie s
    float f=25.5; // Deklaruje i inicjalizuje zmienną typu float o nazwie f
    bool b=true; // Deklaruje i inicjalizuje zmienną typu bool o nazwie b
    string t[4] = {"Volvo", "BMW", "Ford", "Mazda"}; // Deklaruje i inicjalizuje tablicę łańcuchów znaków (string) o nazwie t

    // Wyświetla na ekranie wartości zmiennych oraz tablicy
    cout << "Hello World" << i << s << f << " " << b << "\n";
    
    // Wyświetla elementy tablicy t
    for(int j = 0; j < 4; j++) {
        cout << t[j] << " ";
    }
    cout << "end \n";
    
    // Wyświetla wynik funkcji funkcja1 (należy wywołać funkcję)
    cout << funkcja1() << endl;

    return 0; // Zwraca 0, aby wskazać, że program zakończył się sukcesem
}
