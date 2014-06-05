// Lab 4.1 by Andrew Dykman
// Tuesday Night Intro to Java Class
// Stock Quote Using Methods and Constructors

// Begin Code

public class Stock {

	// Init Vars

	double previousClosingPrice;
	double currentPrice;
	
	// Method for Finding Percent Change
	
	public double changePercent() {
		return (previousClosingPrice / currentPrice - 1.0);
	}
	Stock() {
		previousClosingPrice = 65;
		currentPrice = 60;
	}
	
	// Other Methods
	
	public static void getSymbol(String symbol){
   System.out.print(symbol);
   }
	
	public static void getName(String name){
   System.out.print(name);
   }
	
	public static void getClosingPrice(double closingPrice){
   System.out.print(closingPrice);
   }
	
	public static void getCurrentPrice(double currentPrice){
   System.out.print(currentPrice);
   }
	
	// Begin Main
	
	public static void main(String[] args) {
	
	// Declare Vars
	
	double currentPrice = 65.0;
	double previousClosingPrice = 60.0;
	
	// Constructors and Method Calls and Display Output
	
	Stock changePercent;
	changePercent = new Stock();
	getSymbol("Symbol: ESI\n");
	getName("Name: ITT Tech\n");
	System.out.print("Previous Closing Price: ");
	getClosingPrice(previousClosingPrice);
	System.out.print("\n");
	System.out.print("Current Price: ");
	getCurrentPrice(currentPrice);  
	System.out.print("\n"); 
	System.out.println("Price Change: " + changePercent.changePercent());
	}
}

	// End Code. Huzzah!