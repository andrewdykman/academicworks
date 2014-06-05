// Lab 1.2 Task 1 with Dialog Boxes by Andrew Dykman
// Tuesday Evening Intro to Java Class

import javax.swing.JOptionPane;

public class employeedialog{
	public static void main(String args[]){
	
	// Input Employee Information
	String var1 = JOptionPane.showInputDialog("Enter employee's full name:");
	String var2 = JOptionPane.showInputDialog("Enter number of hours worked in a week:");
	String var3 = JOptionPane.showInputDialog("Enter hourly pay rate:");
	String var4 = JOptionPane.showInputDialog("Enter federal tax witholding rate:");
	String var5 = JOptionPane.showInputDialog("Enter state tax withholding rate:");

	// Do Double Conversions and Fiscal Calculations
	double var6 = Double.parseDouble(var2) * Double.parseDouble(var3);
	double var7 = Double.parseDouble(var4) * var6;
	double var8 = Double.parseDouble(var5) * var6;
	double var9 = var7 + var8;
	double var10 = var6 - var9;
	
	//express results in a dialog messageBox
	JOptionPane.showMessageDialog(null, "Employee Name: " + var1 + "\n\nHours Worked: " + var2 + "\nPay Rate: " + var3 + "\nGross Pay: " + var6 + "\nDeductions:\n Federal Withholding (" + var4 + "%) $" + var7 + "\n State Withholding: (" + var5 + "%) $" + var8 + "\n Total Deductions: " + var9 + "\nNet Pay: $" + var10);
	}
}