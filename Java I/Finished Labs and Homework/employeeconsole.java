// Lab 1.2 Task 2 with Console by Andrew Dykman
// Tuesday Evening Intro to Java Class

import java.util.*;

public class  employeeconsole{

    public static void main(String[] args) {
        //... Initialization
        String var1;                // Declare a variable to hold the name.
		  String var2;
		  String var3;
		  String var4;
		  String var5;
        Scanner in = new Scanner(System.in);

        //... Prompt and read input.
        System.out.print("Enter employee's name: ");
        var1 = in.nextLine();     
		  System.out.print("Enter hours worked this week: ");
        var2 = in.nextLine();    
		  System.out.print("Enter rate of pay: ");
        var3 = in.nextLine();
		  System.out.print("Enter federal tax withholding rate: ");
        var4 = in.nextLine();
		  System.out.print("Enter state tax withholding rate: ");
        var5 = in.nextLine();
		  
		  // Do Double Conversions and Fiscal Calculations
	     double var6 = Double.parseDouble(var2) * Double.parseDouble(var3);
	     double var7 = Double.parseDouble(var4) * var6;
	     double var8 = Double.parseDouble(var5) * var6;
	     double var9 = var7 + var8;
	     double var10 = var6 - var9;
		  
        //... Display output
        System.out.println("Employee Name: " + var1);
		  System.out.println("");
		  System.out.println("Hours Worked: " + var2);
		  System.out.println("Pay Rate: $" + var3);
		  System.out.println(" Federal Withholding: (%" + var4 + ") $" + var7);
		  System.out.println(" State Withholding: (%" + var5 + ") $" + var8);
		  System.out.println(" Total Deduction: $" + var9);
		  System.out.println("Net Pay: $" + var10);
    }
}