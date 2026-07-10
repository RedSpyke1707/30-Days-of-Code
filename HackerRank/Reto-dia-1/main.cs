using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
         int inputInt;
         double inputDouble;
         string inputString;
        
        // Read and save an integer, double, and String to your variables.
         inputInt = Convert.ToInt32(Console.ReadLine());
         inputDouble = Convert.ToDouble(Console.ReadLine());
         inputString = Console.ReadLine();
        
        // Print the sum of both integer variables on a new line.
         Console.WriteLine(i + inputInt);
         
        // Print the sum of the double variables on a new line.
         Console.WriteLine((d + inputDouble).ToString("F1"));
         
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
         Console.WriteLine(s + inputString);
    }
}