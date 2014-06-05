// Andrew Dykman Lab 5.2
// Tuesday Evening Intro to Java

// Begin Code

// Import (Input / Output, Util for Scanner)

import java.io.*;
import java.util.*;

class ReplaceText {

// Begin Main

  public static void main(String[] args) throws Exception {

// Make Sure the User Enters the Correct Parameters when Using Java Com

    if (args.length != 3) {
      System.out.println(
        "Error: Usage Format: java ReplaceText TextFile StringToBeReplaced StringReplacement");
      System.exit(0);
    }
	 
    File sourceFile = new File(args[0]);
	 
// If the File Doesnt Exist Error to the User

    if (!sourceFile.exists()) {
       System.out.println("Error: Text file " + args[0] + " not found.");
       System.exit(0);
    }
    Scanner input = new Scanner(sourceFile);
	 
// Do Our Replacements

    StringBuilder sb = new StringBuilder();
    while (input.hasNext()) {
      String OldString = input.nextLine();
      String NewString = OldString.replaceAll(args[1], args[2]);
      sb.append("\r\n" + NewString);
    }
    input.close();

// Write Back to the Text File with the Replacements

    Formatter output = new Formatter(sourceFile);
    output.format("%s\r\n", sb.toString());
    output.close();
  }
}

// End Code. Huzzah!