using System;

partial class Program
{
    static void Solve(double mealCost, int tipPercent, int taxPercent)
    {
        double tip = mealCost * (tipPercent / 100.0);
        double tax = mealCost * (taxPercent / 100.0);
        double totalCost = mealCost + tip + tax;

        // Math.Round en C# redondea al entero más cercano
        Console.WriteLine($"\nEl costo total es: {Math.Round(totalCost)}");
    }

    static void Main(string[] args)
    {
        Console.Write("Entre el costo de la comida: ");
        string? mealCostInput = Console.ReadLine();
        double mealCost = Convert.ToDouble((mealCostInput ?? string.Empty).Trim());

        Console.Write("Entre el porcentaje de propina: ");
        string? tipPercentInput = Console.ReadLine();
        int tipPercent = Convert.ToInt32((tipPercentInput ?? string.Empty).Trim());

        Console.Write("Entre el porcentaje de impuesto: ");
        string? taxPercentInput = Console.ReadLine();
        int taxPercent = Convert.ToInt32((taxPercentInput ?? string.Empty).Trim());

        Solve(mealCost, tipPercent, taxPercent);
    }
}