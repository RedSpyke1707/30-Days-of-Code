import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;


class Difference {
  	private int[] elements;
  	public int maximumDifference;

	  Difference(int[] elements) {
        this.elements = elements;
    }
    
    public void computeDifference() {
        int max = Integer.MIN_VALUE;
        for (int i = 0; i < elements.length; i++) {
            for (int j = 0; j < elements.length; j++) {
                int diff = Math.abs(elements[i] - elements[j]);
                if (diff > max) {
                    max = diff;
                }
            }
        }
        this.maximumDifference = max;
    }


} // End of Difference class