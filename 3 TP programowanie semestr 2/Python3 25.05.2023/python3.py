i = 1  # Inicjalizacja zmiennej 'i' wartością 1
imax = 100  # Inicjalizacja zmiennej 'imax' wartością 100

# Pętla while, która iteruje dopóki zmienna 'i' jest mniejsza lub równa 'imax'
while i <= imax:
    # Wyświetlenie aktualnej wartości 'i' oraz tekstu "I like Python"
    print(i, "I like Python")
    # Zwiększenie zmiennej 'i' o 1, aby przejść do kolejnej iteracji
    i += 1
else:
    # Ten blok else wykonuje się po zakończeniu pętli while, kiedy 'i' przekroczy 'imax'
    print("Now i =", i)  # Wyświetlenie wartości 'i' po zakończeniu pętli