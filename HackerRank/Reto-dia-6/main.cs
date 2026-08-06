using System;
using System.Text;

partial class Program {
    static void Solve(String[] args) {
        int T = int.Parse(Console.ReadLine());

        for (int t = 0; t < T; t++) {
            string S = Console.ReadLine();
            StringBuilder evenChars = new StringBuilder();
            StringBuilder oddChars = new StringBuilder();

            for (int i = 0; i < S.Length; i++) {
                if (i % 2 == 0) {
                    evenChars.Append(S[i]);
                } else {
                    oddChars.Append(S[i]);
                }
            }

            Console.WriteLine($"{evenChars} {oddChars}");
        }
    }
}