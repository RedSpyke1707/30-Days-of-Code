#!/bin/python3

import math
import os
import random
import re
import sys

#
# Complete the 'solve' function below.
#
# The function accepts following parameters:
#  1. DOUBLE meal_cost
#  2. INTEGER tip_percent
#  3. INTEGER tax_percent
#

def solve(meal_cost, tip_percent, tax_percent):
    # Write your code here
    tip = meal_cost * (tip_percent / 100)
    tax = meal_cost * (tax_percent / 100)
    total_cost = meal_cost + tip + tax
    print(round(total_cost))

    print(f"El costo total de la comida es: {round(total_cost)}")
    
if __name__ == '__main__':
    meal_cost = float(input("Por favor introduzca el precio de la comida:").strip())

    tip_percent = int(input("Introduzca el porciento de la propina:").strip())

    tax_percent = int(input("Introduzca el porciento del impuesto").strip())

    solve(meal_cost, tip_percent, tax_percent)