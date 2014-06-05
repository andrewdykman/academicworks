// Andrew Dykman
// Lab 3.2, Array of Averages
// Intro to Java (Tuesday Night)

// Begin Code

// Import Swing

import javax.swing.*;

    public class AvgArray{
	 
    // Initialize Vars / Double Array
	 
    static double[] b = new double[1000];
    static double sum;
	
    // Getting the Average of All Scores from Double Array
	     
    public static double average(double[] array)
    {
    double sum = 0;
	 double x = 0;
    for (int i = 0; i < b.length; i++)
    {
    sum += b[i];
	 if(b[i] > 0){
	 x++;
	 }
    }
	 double average = sum / x;
    return average;
    }
	 
	 // Getting the Number of Scores Above Average from Double Array
	 
	 public static double numberabove(double[] array)
    {
    double average = average(b);
	 int numberabove = 0;
    for (int i = 0; i < b.length; i++)
    {
	 if(b[i] > average){
	 numberabove++;
	 }
    }
	 
    return numberabove;
    }
	 
	 // Getting the Number of Scores Below Average from Double Array
	 
	 public static double numberbelow(double[] array)
    {
    double average = average(b);
	 int numberbelow = 0;
    for (int i = 0; i < b.length; i++)
    {
	 if(b[i] < average && b[i] != 0){
	 numberbelow++;
	 }
    }
    return numberbelow;
    }
     
    // Begin Main
	 
    public static void main(String args[])
    {
    
	 // For Loop to Enter Scores from JOptionPane
	 
	 // Int Z as Array Index Value Counter, Starting at 0
	 // scoreEntry parsed to enterScore as a Double to Validate Loop, if a Number Less Than 0.0 is Entered Break the Loop
	 
	 double enterScore = 0.0;
	 int blankentry = 0;
	 int x = 0;
	 
	 for(int z=0; enterScore>=0.0;z++) {
	 
		String scoreEntry = JOptionPane.showInputDialog(null, "Enter Score: ");
		
		enterScore = Double.parseDouble(scoreEntry);
		
	 // Make Sure the Only Entries Added to the Array are Positive or 0. Negative Test Scores are Bad Input :D
	 
		if (enterScore > 0){
		b[z] = enterScore;
		}
		if (enterScore == 0){
		blankentry++;
		}
		x++;
	 }  
	 
	 // Make Sure Total Above and Below Are Nice Pretty Integers and Not Doubles
	 // Also Add a Blank Entry if User Tried to Enter a 0
	 
	 int totalabove = (int)numberabove(b);
	 int totalbelow = (int)numberbelow(b);
	 totalbelow += blankentry;
  
  	 // Display Our Output to the User
	 
    System.out.println("Total Average Grade: " + average(b));
	 System.out.println("Total Grades Above the Average: " + totalabove);
	 System.out.println("Total Grades Below the Average: " + totalbelow);
    }
    }
	 
// Begin Code? No... Wait... End Code. Huzzah!