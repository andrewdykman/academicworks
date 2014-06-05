// Andrew Dykman, Lab 5.1
// Tuesday Night Intro to Java

// Begin Code

// Import Crap We Need...
// (Util for Math, I/O for Scanner)

import java.util.*;
import java.io.*;

public class ScannerRandomToArray {

// Begin Main

	public static void main(String[] args) throws Exception {

// Array Stored By Scanner Into ScannerRandomToArray.Txt File

    File file = new File("ScannerRandomToArray.txt");
    if (!file.exists()) {
       Formatter output = new Formatter(file);
       for (int i = 1; i <= 100; i++) {
         output.format("%d ", (int)(Math.random() * 100));
       }
       output.close();
    }

// Scanner From File

    Scanner input = new Scanner(file);

// Make an Array With 100 Spots

    int[] RandomArray = new int[100];
	 
// Fill the Array by Reading Numbers from the Scanner with For Loop

    for (int i = 0; i < 100; i++)
      RandomArray[i] = input.nextInt();
		
// Sort the Numbers in Ascending Order

    Arrays.sort(RandomArray);

    for (int i = 0; i < 100; i++)
	 
// Print all Those Sorted Numbers Out!

      System.out.print(RandomArray[i] + " ");
  }
}

// End Code. Huzzah!
