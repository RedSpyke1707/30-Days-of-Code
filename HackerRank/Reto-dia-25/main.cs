using System;

class Solution {
    static bool IsPrime(int n) {
        if (n <= 1) return false;
        if (n <= 3) return true;
        if (n % 2 == 0 || n % 3 == 0) return false;
        
        for (int i = 5; i * i <= n; i += 6) {
            if (n % i == 0 || n % (i + 2) == 0) return false;
        }
        return true;
    }

    static void Main(string[] args) {
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) return;
        
        int t = int.Parse(input.Trim());
        for (int i = 0; i < t; i++) {
            int n = int.Parse(Console.ReadLine().Trim());
            if (IsPrime(n)) {
                Console.WriteLine("Prime");
            } else {
                Console.WriteLine("Not prime");
            }
        }
    }
}