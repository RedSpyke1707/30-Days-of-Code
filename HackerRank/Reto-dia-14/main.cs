using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;

	public Difference(int[] a) {
        this.elements = a;
    }
    
    public void computeDifference() {
        int max = int.MinValue;
        for (int i = 0; i < elements.Length; i++) {
            for (int j = 0; j < elements.Length; j++) {
                int diff = Math.Abs(elements[i] - elements[j]);
                if (diff > max) {
                    max = diff;
                }
            }
        }
        this.maximumDifference = max;
    }


} // End of Difference Class

partial class Program {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}