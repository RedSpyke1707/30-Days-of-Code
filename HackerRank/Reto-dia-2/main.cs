using System;

namespace HackerRank {
    class Solution {
        static void solve(double meal_cost, int tip_percent, int tax_percent) {
                double tip = meal_cost * tip_percent / 100.0;
                double tax = meal_cost * tax_percent / 100.0;
                int total_cost = (int)Math.Round(meal_cost + tip + tax);
            
            Console.WriteLine(total_cost);
        }

        static void Main(string[] args) {
            string? mealCostLine = Console.ReadLine();
            string? tipPercentLine = Console.ReadLine();
            string? taxPercentLine = Console.ReadLine();

            if (mealCostLine == null || tipPercentLine == null || taxPercentLine == null)
                return;

            double meal_cost = Convert.ToDouble(mealCostLine.Trim());
            int tip_percent = Convert.ToInt32(tipPercentLine.Trim());
            int tax_percent = Convert.ToInt32(taxPercentLine.Trim());

            solve(meal_cost, tip_percent, tax_percent);
        }
    }
}