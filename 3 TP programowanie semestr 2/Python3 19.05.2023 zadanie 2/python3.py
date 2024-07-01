artykul = "woda"  # Zmienna przechowująca nazwę artykułu
smak = "brak"  # Zmienna przechowująca smak artykułu

# Sprawdzenie, czy artykuł to "woda"
if artykul == "woda":
    # Sprawdzenie, czy smak to "brak"
    if smak == "brak":
        rabat = 5  # Jeśli smak to "brak", ustaw rabat na 5%
    else:
        rabat = 2  # Jeśli smak nie jest "brak", ustaw rabat na 2%
else:
    rabat = 1  # Jeśli artykuł nie jest "woda", ustaw rabat na 1%

print(f"Rabat wynosi: {rabat}%")  # Wyświetlenie wartości rabatu

#artykul i woda ma rabat 5 jeśli nie smak to rabat 2 a jak nic to rabat 1