# Zmienna wskazująca, czy tryb automatyczny jest włączony
isAutomaticMode = True

# Zmienna wskazująca, czy jest 80% światła
is80percentLight = True

# Zmienna wskazująca, czy jest bezpośrednie światło
isDirectLight = True

# Zmienna wskazująca, czy jest deszcz
isRainy = True

# Zmienna wskazująca, czy włączyć światła
turnLightsOn = True

# Sprawdzenie, czy tryb automatyczny jest włączony
if isAutomaticMode:
    print("Automatyczne")  # Wydrukowanie komunikatu, że tryb automatyczny jest włączony
    
    # Zmiana wartości zmiennej 'turnLightsOn' w zależności od warunków oświetlenia i pogody
    if not is80percentLight or isDirectLight or isRainy:
        turnLightsOn = True  # Włączenie świateł, jeśli jest ciemno, bezpośrednie światło lub pada deszcz
    else:
        turnLightsOn = False  # Wyłączenie świateł, jeśli jest wystarczająco jasno i nie ma niekorzystnych warunków

# Wydrukowanie stanu zmiennych
print("Automatic mode: ", isAutomaticMode)
print("Is the light good: ", is80percentLight)
print("Is sun low: ", isDirectLight)
print("Is it rainy: ", isRainy)
print("TURN LIGHTS ON: ", turnLightsOn)