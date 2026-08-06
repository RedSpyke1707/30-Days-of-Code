using System;

namespace HackerRank.RetoDia5 {
    class Solution {
        static void Main(string[] args) {
            string? input = Console.ReadLine();
            int n = Convert.ToInt32(input?.Trim() ?? "0");

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
    }
}