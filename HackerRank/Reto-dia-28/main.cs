using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Solution {
    static void Main(String[] args) {
        int n = int.Parse(Console.ReadLine().Trim());
        List<string> gmailNames = new List<string>();
        Regex pattern = new Regex(@"@gmail\.com$");

        for (int i = 0; i < n; i++) {
            string[] tokens = Console.ReadLine().Trim().Split(' ');
            string firstName = tokens[0];
            string emailId = tokens[1];

            if (pattern.IsMatch(emailId)) {
                gmailNames.Add(firstName);
            }
        }

        gmailNames.Sort();

        foreach (string name in gmailNames) {
            Console.WriteLine(name);
        }
    }
}