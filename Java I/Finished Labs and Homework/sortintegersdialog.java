// Lab 2 Task 1.1 with Dialog Boxes by Andrew Dykman
// Sorting Integers
// Tuesday Evening Intro to Java Class

import javax.swing.JOptionPane;

public class sortintegersdialog{
	public static void main(String args[]){
	
	// Declare Final Sorted Numbers as Global Integer Variable-Types
	
	int sorted1;
	int sorted2;
	int sorted3;
	
	// Input Integers From the User
	
	String var1 = JOptionPane.showInputDialog("Enter the first integer:");
	String var2 = JOptionPane.showInputDialog("Enter the second integer:");
	String var3 = JOptionPane.showInputDialog("Enter the third integer:");
	
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
	
	JOptionPane.showMessageDialog(null, "The sorted numbers are " + sorted1 + " " + sorted2 + " " + sorted3);
	}
}