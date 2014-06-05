// Lab 2 Task 2 by Andrew Dykman
// Creating a Yearly Calander in the Console
// Tuesday Evening Intro to Java Class

import javax.swing.JOptionPane;
import java.util.*;

public class calander{
	public static void main(String args[]){
	
	// Get the Year
	
	String variable1 = JOptionPane.showInputDialog("Enter a year:");
	
	// Convert the Year from a String to an Integer Variable
	// and Assign it to Variable 2
	
	int variable2 = Integer.parseInt(variable1);
	
	// Get the First Day of the Year as a Starting Point
	
	String variable3 = JOptionPane.showInputDialog("Enter the first day of the year:\n(Sunday = 1, Monday = 2, Tuesday = 3, etc..)");
	
	// Convert the Day from a String to an Integer Variable
	// and Assign it to Variable 4
		
	int variable4 = Integer.parseInt(variable3);
	
	// Assign an Integer to Determine Number of Days in the Month
	
	int variable5 = 0;
	
	// Assign a Integers to Display Days on the Calender While Using
	// Nested For Loops for Output
	
	int variable6 = 31;
	int variable7 = 31;
	int variable8 = 30;
	int variable9 = 31;
	int variable10 = 30;
	int variable11 = 31;
	int variable12 = 31;
	int variable13 = 30;
	int variable14 = 31;
	int variable15 = 30;
	int variable16 = 31;
	
	// Use a For Loop to Go Through all 12 Months Adding Days for Each Month
	
	int nextmonth = 0;
	
	for(int i=1; i<=12; i++){
	
	switch (i) {
  case 1: 
    variable5 = variable5 + 31;
	 System.out.println("           January " + variable2);
	 System.out.println("----------------------------");
	 System.out.println("Sun Mon Tue Wed Thu Fri Sat");
	 if (variable4 == 2){
	 System.out.print("    ");
	 }
	 if (variable4 == 3){
	 System.out.print("        ");
	 }
	 if (variable4 == 4){
	 System.out.print("            ");
	 }
	 if (variable4 == 5){
	 System.out.print("                ");
	 }
	 if (variable4 == 6){
	 System.out.print("                    ");
	 }
	 if (variable4 == 7){
	 System.out.print("                        ");
	 }
	 int lineoverflow = variable4;
	 if (lineoverflow == 1){
	 lineoverflow = 0;
	 }
	 if (lineoverflow == 2){
	 lineoverflow = 1;
	 }
	 if (lineoverflow == 3){
	 lineoverflow = 2;
	 }
	 if (lineoverflow == 4){
	 lineoverflow = 3;
	 }
	 if (lineoverflow == 5){
	 lineoverflow = 4;
	 }
	 if (lineoverflow == 6){
	 lineoverflow = 5;
	 }
	 if (lineoverflow == 7){
	 lineoverflow = 6;
	 }
	 variable4 = 1;
	 for(int january=variable4; january<=variable6; january++){
	 if (lineoverflow == 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (lineoverflow > 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (january < 10){
	 System.out.print(" ");
	 }
	 System.out.print(" " + january + " ");
	 lineoverflow++;
	 nextmonth = lineoverflow;
	 }
    break;
  case 2:

// Now Lets Find Out If It Is a Leap Year
// Add an Extra Day If It Is.
  nextmonth = nextmonth + 1;
  lineoverflow = nextmonth;
  System.out.println("");
  System.out.println("");
  int leapyear = 28;

	if ((variable2 % 4 == 0) && variable2 % 100 != 0)
		{
   		leapyear = 29;
      }
   else if ((variable2 % 4 == 0) && (variable2 % 100 == 0) && (variable2 % 400 == 0))
      {
   		leapyear = 29;
      }
   else
      {
   		leapyear = 28;
      }
	 System.out.println("           February " + variable2);
	 System.out.println("----------------------------");
	 System.out.println("Sun Mon Tue Wed Thu Fri Sat");
	 if (lineoverflow == 2){
	 System.out.print("    ");
	 }
	 if (lineoverflow == 3){
	 System.out.print("        ");
	 }
	 if (lineoverflow == 4){
	 System.out.print("            ");
	 }
	 if (lineoverflow == 5){
	 System.out.print("                ");
	 }
	 if (lineoverflow == 6){
	 System.out.print("                    ");
	 }
	 if (lineoverflow == 7){
	 System.out.print("                        ");
	 }
	 if (lineoverflow == 1){
	 lineoverflow = 0;
	 }
	 if (lineoverflow == 2){
	 lineoverflow = 1;
	 }
	 if (lineoverflow == 3){
	 lineoverflow = 2;
	 }
	 if (lineoverflow == 4){
	 lineoverflow = 3;
	 }
	 if (lineoverflow == 5){
	 lineoverflow = 4;
	 }
	 if (lineoverflow == 6){
	 lineoverflow = 5;
	 }
	 if (lineoverflow == 7){
	 lineoverflow = 6;
	 }
	 int febcountingmonth = 1;
	 for(int february=febcountingmonth; february<=leapyear; february++){
	 if (lineoverflow == 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (lineoverflow > 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (february < 10){
	 System.out.print(" ");
	 }
	 System.out.print(" " + february + " ");
	 lineoverflow++;
	 nextmonth = lineoverflow;
	 }
  
    break;
  case 3: 
  	 System.out.println("");
	 System.out.println("");
    lineoverflow = nextmonth + 1;
    System.out.println("           March " + variable2);
	 System.out.println("----------------------------");
	 System.out.println("Sun Mon Tue Wed Thu Fri Sat");
	 if (lineoverflow == 2){
	 System.out.print("    ");
	 }
	 if (lineoverflow == 3){
	 System.out.print("        ");
	 }
	 if (lineoverflow == 4){
	 System.out.print("            ");
	 }
	 if (lineoverflow == 5){
	 System.out.print("                ");
	 }
	 if (lineoverflow == 6){
	 System.out.print("                    ");
	 }
	 if (lineoverflow == 7){
	 System.out.print("                        ");
	 }
	 if (lineoverflow == 1){
	 lineoverflow = 0;
	 }
	 if (lineoverflow == 2){
	 lineoverflow = 1;
	 }
	 if (lineoverflow == 3){
	 lineoverflow = 2;
	 }
	 if (lineoverflow == 4){
	 lineoverflow = 3;
	 }
	 if (lineoverflow == 5){
	 lineoverflow = 4;
	 }
	 if (lineoverflow == 6){
	 lineoverflow = 5;
	 }
	 if (lineoverflow == 7){
	 lineoverflow = 6;
	 }
	 int marchcountingmonth = 1;
	 for(int march=marchcountingmonth; march<=31; march++){
	 if (lineoverflow == 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (lineoverflow > 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (march < 10){
	 System.out.print(" ");
	 }
	 System.out.print(" " + march + " ");
	 lineoverflow++;
	 nextmonth = lineoverflow;
	 }

    variable5 = variable5 + 31;
    break;
  case 4: 
    System.out.println("");
	 System.out.println("");
    lineoverflow = nextmonth + 1;
    System.out.println("           April " + variable2);
	 System.out.println("----------------------------");
	 System.out.println("Sun Mon Tue Wed Thu Fri Sat");
	 if (lineoverflow == 2){
	 System.out.print("    ");
	 }
	 if (lineoverflow == 3){
	 System.out.print("        ");
	 }
	 if (lineoverflow == 4){
	 System.out.print("            ");
	 }
	 if (lineoverflow == 5){
	 System.out.print("                ");
	 }
	 if (lineoverflow == 6){
	 System.out.print("                    ");
	 }
	 if (lineoverflow == 7){
	 System.out.print("                        ");
	 }
	 if (lineoverflow == 1){
	 lineoverflow = 0;
	 }
	 if (lineoverflow == 2){
	 lineoverflow = 1;
	 }
	 if (lineoverflow == 3){
	 lineoverflow = 2;
	 }
	 if (lineoverflow == 4){
	 lineoverflow = 3;
	 }
	 if (lineoverflow == 5){
	 lineoverflow = 4;
	 }
	 if (lineoverflow == 6){
	 lineoverflow = 5;
	 }
	 if (lineoverflow == 7){
	 lineoverflow = 6;
	 }
	 int aprilcountingmonth = 1;
	 for(int april=aprilcountingmonth; april<=30; april++){
	 if (lineoverflow == 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (lineoverflow > 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (april < 10){
	 System.out.print(" ");
	 }
	 System.out.print(" " + april + " ");
	 lineoverflow++;
	 nextmonth = lineoverflow;
	 }

    variable5 = variable5 + 30;
    break;
  case 5: 
    System.out.println("");
	 System.out.println("");
    lineoverflow = nextmonth + 1;
    System.out.println("           May " + variable2);
	 System.out.println("----------------------------");
	 System.out.println("Sun Mon Tue Wed Thu Fri Sat");
	 if (lineoverflow == 2){
	 System.out.print("    ");
	 }
	 if (lineoverflow == 3){
	 System.out.print("        ");
	 }
	 if (lineoverflow == 4){
	 System.out.print("            ");
	 }
	 if (lineoverflow == 5){
	 System.out.print("                ");
	 }
	 if (lineoverflow == 6){
	 System.out.print("                    ");
	 }
	 if (lineoverflow == 7){
	 System.out.print("                        ");
	 }
	 if (lineoverflow == 1){
	 lineoverflow = 0;
	 }
	 if (lineoverflow == 2){
	 lineoverflow = 1;
	 }
	 if (lineoverflow == 3){
	 lineoverflow = 2;
	 }
	 if (lineoverflow == 4){
	 lineoverflow = 3;
	 }
	 if (lineoverflow == 5){
	 lineoverflow = 4;
	 }
	 if (lineoverflow == 6){
	 lineoverflow = 5;
	 }
	 if (lineoverflow == 7){
	 lineoverflow = 6;
	 }
	 int maycountingmonth = 1;
	 for(int may=maycountingmonth; may<=31; may++){
	 if (lineoverflow == 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (lineoverflow > 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (may < 10){
	 System.out.print(" ");
	 }
	 System.out.print(" " + may + " ");
	 lineoverflow++;
	 nextmonth = lineoverflow;
	 }

    variable5 = variable5 + 31;
    break;
  case 6: 
    System.out.println("");
	 System.out.println("");
    lineoverflow = nextmonth + 1;
    System.out.println("           June " + variable2);
	 System.out.println("----------------------------");
	 System.out.println("Sun Mon Tue Wed Thu Fri Sat");
	 if (lineoverflow == 2){
	 System.out.print("    ");
	 }
	 if (lineoverflow == 3){
	 System.out.print("        ");
	 }
	 if (lineoverflow == 4){
	 System.out.print("            ");
	 }
	 if (lineoverflow == 5){
	 System.out.print("                ");
	 }
	 if (lineoverflow == 6){
	 System.out.print("                    ");
	 }
	 if (lineoverflow == 7){
	 System.out.print("                        ");
	 }
	 if (lineoverflow == 1){
	 lineoverflow = 0;
	 }
	 if (lineoverflow == 2){
	 lineoverflow = 1;
	 }
	 if (lineoverflow == 3){
	 lineoverflow = 2;
	 }
	 if (lineoverflow == 4){
	 lineoverflow = 3;
	 }
	 if (lineoverflow == 5){
	 lineoverflow = 4;
	 }
	 if (lineoverflow == 6){
	 lineoverflow = 5;
	 }
	 if (lineoverflow == 7){
	 lineoverflow = 6;
	 }
	 int junecountingmonth = 1;
	 for(int june=junecountingmonth; june<=30; june++){
	 if (lineoverflow == 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (lineoverflow > 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (june < 10){
	 System.out.print(" ");
	 }
	 System.out.print(" " + june + " ");
	 lineoverflow++;
	 nextmonth = lineoverflow;
	 }

    variable5 = variable5 + 30;
    break;
  case 7: 
    System.out.println("");
	 System.out.println("");
    lineoverflow = nextmonth + 1;
    System.out.println("           July " + variable2);
	 System.out.println("----------------------------");
	 System.out.println("Sun Mon Tue Wed Thu Fri Sat");
	 if (lineoverflow == 2){
	 System.out.print("    ");
	 }
	 if (lineoverflow == 3){
	 System.out.print("        ");
	 }
	 if (lineoverflow == 4){
	 System.out.print("            ");
	 }
	 if (lineoverflow == 5){
	 System.out.print("                ");
	 }
	 if (lineoverflow == 6){
	 System.out.print("                    ");
	 }
	 if (lineoverflow == 7){
	 System.out.print("                        ");
	 }
	 if (lineoverflow == 1){
	 lineoverflow = 0;
	 }
	 if (lineoverflow == 2){
	 lineoverflow = 1;
	 }
	 if (lineoverflow == 3){
	 lineoverflow = 2;
	 }
	 if (lineoverflow == 4){
	 lineoverflow = 3;
	 }
	 if (lineoverflow == 5){
	 lineoverflow = 4;
	 }
	 if (lineoverflow == 6){
	 lineoverflow = 5;
	 }
	 if (lineoverflow == 7){
	 lineoverflow = 6;
	 }
	 int julycountingmonth = 1;
	 for(int july=julycountingmonth; july<=31; july++){
	 if (lineoverflow == 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (lineoverflow > 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (july < 10){
	 System.out.print(" ");
	 }
	 System.out.print(" " + july + " ");
	 lineoverflow++;
	 nextmonth = lineoverflow;
	 }

    variable5 = variable5 + 31;
    break;
  case 8: 
    System.out.println("");
	 System.out.println("");
    lineoverflow = nextmonth + 1;
    System.out.println("           August " + variable2);
	 System.out.println("----------------------------");
	 System.out.println("Sun Mon Tue Wed Thu Fri Sat");
	 if (lineoverflow == 2){
	 System.out.print("    ");
	 }
	 if (lineoverflow == 3){
	 System.out.print("        ");
	 }
	 if (lineoverflow == 4){
	 System.out.print("            ");
	 }
	 if (lineoverflow == 5){
	 System.out.print("                ");
	 }
	 if (lineoverflow == 6){
	 System.out.print("                    ");
	 }
	 if (lineoverflow == 7){
	 System.out.print("                        ");
	 }
	 if (lineoverflow == 1){
	 lineoverflow = 0;
	 }
	 if (lineoverflow == 2){
	 lineoverflow = 1;
	 }
	 if (lineoverflow == 3){
	 lineoverflow = 2;
	 }
	 if (lineoverflow == 4){
	 lineoverflow = 3;
	 }
	 if (lineoverflow == 5){
	 lineoverflow = 4;
	 }
	 if (lineoverflow == 6){
	 lineoverflow = 5;
	 }
	 if (lineoverflow == 7){
	 lineoverflow = 6;
	 }
	 int augustcountingmonth = 1;
	 for(int august=augustcountingmonth; august<=31; august++){
	 if (lineoverflow == 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (lineoverflow > 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (august < 10){
	 System.out.print(" ");
	 }
	 System.out.print(" " + august + " ");
	 lineoverflow++;
	 nextmonth = lineoverflow;
	 }

    variable5 = variable5 + 31;
    break;
  case 9: 
    System.out.println("");
	 System.out.println("");
    lineoverflow = nextmonth + 1;
    System.out.println("           September " + variable2);
	 System.out.println("----------------------------");
	 System.out.println("Sun Mon Tue Wed Thu Fri Sat");
	 if (lineoverflow == 2){
	 System.out.print("    ");
	 }
	 if (lineoverflow == 3){
	 System.out.print("        ");
	 }
	 if (lineoverflow == 4){
	 System.out.print("            ");
	 }
	 if (lineoverflow == 5){
	 System.out.print("                ");
	 }
	 if (lineoverflow == 6){
	 System.out.print("                    ");
	 }
	 if (lineoverflow == 7){
	 System.out.print("                        ");
	 }
	 if (lineoverflow == 1){
	 lineoverflow = 0;
	 }
	 if (lineoverflow == 2){
	 lineoverflow = 1;
	 }
	 if (lineoverflow == 3){
	 lineoverflow = 2;
	 }
	 if (lineoverflow == 4){
	 lineoverflow = 3;
	 }
	 if (lineoverflow == 5){
	 lineoverflow = 4;
	 }
	 if (lineoverflow == 6){
	 lineoverflow = 5;
	 }
	 if (lineoverflow == 7){
	 lineoverflow = 6;
	 }
	 int septembercountingmonth = 1;
	 for(int september=septembercountingmonth; september<=30; september++){
	 if (lineoverflow == 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (lineoverflow > 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (september < 10){
	 System.out.print(" ");
	 }
	 System.out.print(" " + september + " ");
	 lineoverflow++;
	 nextmonth = lineoverflow;
	 }

    variable5 = variable5 + 30;
    break;
  case 10: 
    System.out.println("");
	 System.out.println("");
    lineoverflow = nextmonth + 1;
    System.out.println("           October " + variable2);
	 System.out.println("----------------------------");
	 System.out.println("Sun Mon Tue Wed Thu Fri Sat");
	 if (lineoverflow == 2){
	 System.out.print("    ");
	 }
	 if (lineoverflow == 3){
	 System.out.print("        ");
	 }
	 if (lineoverflow == 4){
	 System.out.print("            ");
	 }
	 if (lineoverflow == 5){
	 System.out.print("                ");
	 }
	 if (lineoverflow == 6){
	 System.out.print("                    ");
	 }
	 if (lineoverflow == 7){
	 System.out.print("                        ");
	 }
	 if (lineoverflow == 1){
	 lineoverflow = 0;
	 }
	 if (lineoverflow == 2){
	 lineoverflow = 1;
	 }
	 if (lineoverflow == 3){
	 lineoverflow = 2;
	 }
	 if (lineoverflow == 4){
	 lineoverflow = 3;
	 }
	 if (lineoverflow == 5){
	 lineoverflow = 4;
	 }
	 if (lineoverflow == 6){
	 lineoverflow = 5;
	 }
	 if (lineoverflow == 7){
	 lineoverflow = 6;
	 }
	 int octobercountingmonth = 1;
	 for(int october=octobercountingmonth; october<=31; october++){
	 if (lineoverflow == 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (lineoverflow > 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (october < 10){
	 System.out.print(" ");
	 }
	 System.out.print(" " + october + " ");
	 lineoverflow++;
	 nextmonth = lineoverflow;
	 }

    variable5 = variable5 + 31;
    break;
  case 11: 
    System.out.println("");
	 System.out.println("");
    lineoverflow = nextmonth + 1;
    System.out.println("           November " + variable2);
	 System.out.println("----------------------------");
	 System.out.println("Sun Mon Tue Wed Thu Fri Sat");
	 if (lineoverflow == 2){
	 System.out.print("    ");
	 }
	 if (lineoverflow == 3){
	 System.out.print("        ");
	 }
	 if (lineoverflow == 4){
	 System.out.print("            ");
	 }
	 if (lineoverflow == 5){
	 System.out.print("                ");
	 }
	 if (lineoverflow == 6){
	 System.out.print("                    ");
	 }
	 if (lineoverflow == 7){
	 System.out.print("                        ");
	 }
	 if (lineoverflow == 1){
	 lineoverflow = 0;
	 }
	 if (lineoverflow == 2){
	 lineoverflow = 1;
	 }
	 if (lineoverflow == 3){
	 lineoverflow = 2;
	 }
	 if (lineoverflow == 4){
	 lineoverflow = 3;
	 }
	 if (lineoverflow == 5){
	 lineoverflow = 4;
	 }
	 if (lineoverflow == 6){
	 lineoverflow = 5;
	 }
	 if (lineoverflow == 7){
	 lineoverflow = 6;
	 }
	 int novembercountingmonth = 1;
	 for(int november=novembercountingmonth; november<=30; november++){
	 if (lineoverflow == 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (lineoverflow > 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (november < 10){
	 System.out.print(" ");
	 }
	 System.out.print(" " + november + " ");
	 lineoverflow++;
	 nextmonth = lineoverflow;
	 }

    variable5 = variable5 + 30;
    break;
  case 12: 
    System.out.println("");
	 System.out.println("");
    lineoverflow = nextmonth + 1;
    System.out.println("           December " + variable2);
	 System.out.println("----------------------------");
	 System.out.println("Sun Mon Tue Wed Thu Fri Sat");
	 if (lineoverflow == 2){
	 System.out.print("    ");
	 }
	 if (lineoverflow == 3){
	 System.out.print("        ");
	 }
	 if (lineoverflow == 4){
	 System.out.print("            ");
	 }
	 if (lineoverflow == 5){
	 System.out.print("                ");
	 }
	 if (lineoverflow == 6){
	 System.out.print("                    ");
	 }
	 if (lineoverflow == 7){
	 System.out.print("                        ");
	 }
	 if (lineoverflow == 1){
	 lineoverflow = 0;
	 }
	 if (lineoverflow == 2){
	 lineoverflow = 1;
	 }
	 if (lineoverflow == 3){
	 lineoverflow = 2;
	 }
	 if (lineoverflow == 4){
	 lineoverflow = 3;
	 }
	 if (lineoverflow == 5){
	 lineoverflow = 4;
	 }
	 if (lineoverflow == 6){
	 lineoverflow = 5;
	 }
	 if (lineoverflow == 7){
	 lineoverflow = 6;
	 }
	 int decembercountingmonth = 1;
	 for(int december=decembercountingmonth; december<=31; december++){
	 if (lineoverflow == 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (lineoverflow > 7){
	 System.out.println("");
	 lineoverflow = 0;
	 }
	 if (december < 10){
	 System.out.print(" ");
	 }
	 System.out.print(" " + december + " ");
	 lineoverflow++;
	 nextmonth = lineoverflow;
	 }

    variable5 = variable5 + 31;
    break;
  default: 
    variable5 = variable5 + 0;
}
         }

		}
}