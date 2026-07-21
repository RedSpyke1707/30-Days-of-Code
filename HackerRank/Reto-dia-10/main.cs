using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

partial class Program {
    public static void Main() {
        int n = int.Parse(Console.ReadLine().Trim());
        string binary = Convert.ToString(n, 2); // convierte n a string binario
        
        int maxCount = 0;
        int currentCount = 0;
        
        foreach (char bit in binary) {
            if (bit == '1') {
                currentCount++;
                maxCount = Math.Max(maxCount, currentCount);
            } else {
                currentCount = 0;
            }
        }
        
        Console.WriteLine(maxCount);
    }
}