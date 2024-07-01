# Wyświetlanie liczb od 0 do 19
for number in range(20):
    print(number)

# Wyświetlanie liczb od 1 do 20 z informacją, czy liczba jest parzysta czy nieparzysta
for number in range(1, 21):
    if number % 2 == 0:  # Sprawdzanie, czy liczba jest parzysta
        print('Number %2d is %s' % (number, 'even'))
    else:  # Jeśli liczba nie jest parzysta, jest nieparzysta
        print('Number %2d is %s' % (number, 'odd'))

# Wyświetlanie liczb od 1 do 20 z krokiem co 2, czyli tylko liczby nieparzyste
for numberTwo in range(1, 21, 2):
    print(numberTwo)

# Odwrócenie kolejności listy
numbers_list = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]  # Przykładowa lista liczb
reversed_list = numbers_list[::-1]  # Odwracanie listy
print('Original list:', numbers_list)
print('Reversed list:', reversed_list)