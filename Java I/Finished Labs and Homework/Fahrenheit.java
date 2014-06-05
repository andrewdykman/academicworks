import javax.swing.JOptionPane;

public class Fahrenheit{
	public static void main(String args[]){
	
	// Input Fahreinheit
	String var1 = JOptionPane.showInputDialog("Enter Fahrenheit");
	
	// Convert Fahrenheit to Double
	double var2 = Double.parseDouble(var1);
	
	// Convert Fahrenheit to Celsius Using a Formula
	double Celsius = (5.0 / 9.0) * (var2 - 32);
	
	
	// Express Results in a Dialog MessageBox
	JOptionPane.showMessageDialog(null, "The temperature is " + Celsius + " in Celsius");
	}
}