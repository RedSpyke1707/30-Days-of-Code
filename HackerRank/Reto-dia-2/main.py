def solve(meal_cost, tip_percent, tax_percent):
    tip = meal_cost * (tip_percent / 100)
    tax = meal_cost * (tax_percent / 100)
    total_cost = meal_cost + tip + tax
    print(round(total_cost))

    print(f"El costo total de la comida es: {round(total_cost)}")

if __name__ == '__main__':
    print("Bienvenido a nuestro menu de restaurante, por favor seleccione la opcion de su preferencia.")
    
    print(input("1. Menu del dia \n2. Menu de la semana \n3. Menu del mes \n4. Menu de temporada \n5. Menu especial"))
if input("Seleccione una opcion: ") in ['1', '2', '3', '4', '5']:
    
    meal_cost = float(input("introduzca el costo de la comida: ").strip())

    tip_percent = int(input("introduzca el porcentaje de propina: ").strip())

    tax_percent = int(input("introduzca el porcentaje de impuesto: ").strip())

    solve(meal_cost, tip_percent, tax_percent)
