using System;

class Solution {
    static void Main(String[] args) {
        string[] actualDateInput = Console.ReadLine().Trim().Split(' ');
        int d1 = int.Parse(actualDateInput[0]);
        int m1 = int.Parse(actualDateInput[1]);
        int y1 = int.Parse(actualDateInput[2]);

        string[] expectedDateInput = Console.ReadLine().Trim().Split(' ');
        int d2 = int.Parse(expectedDateInput[0]);
        int m2 = int.Parse(expectedDateInput[1]);
        int y2 = int.Parse(expectedDateInput[2]);

        int fine = 0;

        if (y1 > y2) {
            fine = 10000;
        } else if (y1 == y2) {
            if (m1 > m2) {
                fine = 500 * (m1 - m2);
            } else if (m1 == m2 && d1 > d2) {
                fine = 15 * (d1 - d2);
            }
        }

        Console.WriteLine(fine);
    }
}