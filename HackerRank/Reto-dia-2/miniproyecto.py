def solve(meal_cost, tip_percent, tax_percent):
    tip = meal_cost * (tip_percent / 100)
    tax = meal_cost * (tax_percent / 100)
    total_cost = meal_cost + tip + tax
    print(round(total_cost))

    print(f"El costo total de la comida es: {round(total_cost)}")

    Menu = {
        "ensalada": 85.00,
        "sopa": 40.00,
        "Arroz con pollo": 150.00,
        "pasta": 135.00,
        "hamburguesa": 120.00
    }

    Porcentaje_impuesto = 0.18
    Porcentaje_propina  = 0.10

if __name__ == '__main__':

    print("Bienvenido a nuestro menu de restaurante, por favor seleccione la opcion de su preferencia.")
    print("Menu del dia")
    print("ensalada" " $85.00")
    print("sopa" " $40.00")
    print("Arroz con pollo" " $150.00")  
    print("Pasta" " $135.00")
    print("Hamburguesa  $120.00\n")

    eleccion = input("¿Que plato desea ordenar?").lower().strip()

    if eleccion in menu:("Ensalada, sopa, Arroz, Pasta, Hamburguesa")
    print("seleccine su plata por favor")
    costo_base = menu[eleccion] 

    print("\n--- DETALLE DE SU CUENTA ---")
    print(f"Plato: {eleccion.capitalize()}")
    print(f"Precio base: ${costo_base:.2f}")
    print(f"Impuesto (18%): ${impuesto:.2f}")
    print(f"Propina sugerida (10%): ${propina:.2f}")
    print("----------------------------")
    print(f"El costo total de la comida es: {round(total_cost)}")

else:
    print("\nLo sentimos, ese plato no está en el menú del día. Por favor, intente de nuevo.")




    meal_cost = float(input("introduzca el costo de la comida: ").strip())

    tip_percent = int(input("introduzca el porcentaje de propina: ").strip())

    tax_percent = int(input("introduzca el porcentaje de impuesto: ").strip())

    solve(meal_cost, tip_percent, tax_percent)
