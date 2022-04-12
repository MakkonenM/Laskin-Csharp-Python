
# Yksinkertainen laskin

# Tämä funktio lisää kaksi numeroa
def add(x, y):
    return x + y

# Tämä funktio vähentää kaksi lukua
def subtract(x, y):
    return x - y

# Tämä funktio kertaa kaksi lukua
def multiply(x, y):
    return x * y

# Tämä funktio jakaa kaksi lukua
def divide(x, y):
    return x / y


print("Valitse operaattori.")
print("1.Lisää")
print("2.Vähennä")
print("3.Kertaa")
print("4.Jaa")

while True:
    # Ottaa syötteen käyttäjältä
    choice = input("Valitse vaihtoehto(1/2/3/4): ")

    # Tarkistetaan onko syöte yksi näistä vaihtoehdoista
    if choice in ('1', '2', '3', '4'):
        num1 = float(input("Laita eka numero: "))
        num2 = float(input("Laita toinen numero: "))

        if choice == '1':
            print(num1, "+", num2, "=", add(num1, num2))

        elif choice == '2':
            print(num1, "-", num2, "=", subtract(num1, num2))

        elif choice == '3':
            print(num1, "*", num2, "=", multiply(num1, num2))

        elif choice == '4':
            print(num1, "/", num2, "=", divide(num1, num2))
        
        # Kysytään haluuko käyttäjä laskea uudelleen
        # Rikotaan looppi, jos vastaus on ei
        next_calculation = input("Tehdäänkö uusi lasku? (kyllä/ei): ")
        if next_calculation == "ei":
          break
    
    else:
        print("Virheellinen syöte")