// Lab 2 Task 1.1 with the Console by Andrew Dykman
// Sorting Integers
// Tuesday Evening Intro to Java Class

import java.util.*;

public class sortintegersconsole{
	public static void main(String args[]){
	
	// Declare Final Sorted Numbers as Global Integer Variable-Types
	
	int sorted1;
	int sorted2;
	int sorted3;
	
	// Initialize String Variables and Console Input
	
	String var1;
	String var2;
	String var3;
	Scanner in = new Scanner(System.in);
	
	// Input Integers From the User
	
	System.out.print("Enter the first integer: ");
   	var1 = in.nextLine();
	System.out.print("Enter the second integer: ");
   	var2 = in.nextLine();
	System.out.print("Enter the third integer: ");
   	var3 = in.nextLine();
	
	// Do String to Integer Conversions
	
	int num1 = Integer.parseInt(var1);
	int num2 = Integer.parseInt(var2);
	int num3 = Integer.parseInt(var3);
	
	// Multiple If Statements to Evaluate Display Order
	
	// Evaluate Highest Number
	
	if(num1 > num2 && num1 > num3){
		sorted3 = num1;}
	else
	if(num2 > num1 && num2 > num3){
		sorted3 = num2;}
	else {sorted3 = num3;};
 
 	// Evaluate Middle Number
	            
   if(num1 < num2 && num1 > num3 || num1 > num2 && num1 < num3){
      sorted2 = num1;}
   else
   if(num2 < num1 && num2 > num3 || num2 > num1 && num2 < num3){
      sorted2 = num2;}
   else{sorted2 = num3;};
 
 	// Evaluate Lowest Number
	            
   if(num1 < num2 && num1 < num3){
      sorted1 = num1;}
   else
   if(num2 < num3 && num2 < num3){
      sorted1 = num2;}
   else {sorted1 = num3;};
	
	//Express Results in a Dialog messageBox
	
	 System.out.println("The sorted numbers are: " + sorted1 + " " + sorted2 + " " + sorted3);
	}
}