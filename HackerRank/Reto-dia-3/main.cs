using System;

namespace HackerRank.RetoDia3 {
    class Solution {
        static void Main(string[] args) {
            string? input = Console.ReadLine();
            if (input == null) {
                return;
            }

            int N = Convert.ToInt32(input.Trim());

            if (N % 2 != 0) {
                Console.WriteLine("Weird");
            } else {
                if (N >= 2 && N <= 5) {
                    Console.WriteLine("Not Weird");
                } else if (N >= 6 && N <= 20) {
                    Console.WriteLine("Weird");
                } else if (N > 20) {
                    Console.WriteLine("Not Weird");
                }
            }
        }
    }
}
