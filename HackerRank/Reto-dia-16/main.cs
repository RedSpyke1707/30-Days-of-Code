using System;

class SolutionDay16 {
    static void Main(String[] args) {
        string S = Console.ReadLine();
        
        try {
            int num = Convert.ToInt32(S);
            Console.WriteLine(num);
        } catch (FormatException e) {
            Console.WriteLine("Bad String");
        }
    }
}