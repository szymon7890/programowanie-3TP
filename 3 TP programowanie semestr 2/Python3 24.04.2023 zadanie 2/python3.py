persons = ['Szymon', 'Alicja', 'Mikołaj', 'Kasia']  # Lista osób

domain = 'mycompany.com'  # Domena e-mailowa

# Pętla for iterująca po każdej osobie w liście persons
for person in persons:
    email = person + '@' + domain  # Tworzenie adresu e-mail przez połączenie imienia z domeną
    # Wyświetlenie adresu e-mail z tabulatorem (t oznacza tabulator)
    print('Email for\t', person, '\tis\t', email)
else:
    # Komunikat wyświetlany po zakończeniu pętli for
    print('-- end of the list --')