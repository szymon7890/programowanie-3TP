values = [10, 43, 12, 48, 12, 11, 18, 98, 57, 28, 19, 27, 49, 19, 74]  # Lista wartości

i = 0  # Inicjalizacja zmiennej indeksu na 0
max = len(values) - 2  # Maksymalny indeks do sprawdzenia, zatrzymujemy się na przedostatnim trójkowym zestawie

# Pętla while działająca dopóki indeks i jest mniejszy od max
while i < max:
    # Wyświetlenie aktualnego indeksu i oraz wartości trzech kolejnych elementów listy
    print(i, values[i], values[i + 1], values[i + 2])
    
    # Sprawdzenie, czy wartości są w porządku rosnącym
    if values[i] < values[i + 1] and values[i + 1] < values[i + 2]:
        # Jeśli wartości są w porządku rosnącym, wyświetlenie komunikatu
        print('\tFound:', values[i], values[i + 1], values[i + 2])
    
    i += 1  # Inkrementacja indeksu