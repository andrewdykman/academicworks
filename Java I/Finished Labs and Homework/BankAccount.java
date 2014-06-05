// Andrew Dykman, Lab 6.1
// Bank Account to Determine Monthly Interest, Date Created, Etc...
// Tuesday Night Intro to Java Class

// Begin Code

public class BankAccount {

// Begin Main

  public static void main (String[] args) {
    Account account = new Account(1122, 20000, 4.5);

    account.withdraw(10000);
    account.deposit(3000);
    System.out.println("Balance Is: " + account.getBalance());
    System.out.println("Monthly Interest Is: " +
      account.getMonthlyInterest());
    System.out.println("This Account Was Created At: " +
      account.getDateCreated());
  }
}

// Class for Account

class Account {

// Declare Private Vars and Account Methods

  private int id;
  private double balance;
  private double annualInterestRate;
  private java.util.Date dateCreated;
  public Account() {
    dateCreated = new java.util.Date();
  }
  public Account(int id, double balance, double annualInterestRate) {
    this.id = id;
    this.balance = balance;
    this.annualInterestRate = annualInterestRate;
    dateCreated = new java.util.Date();
  }
  public int getId() {
    return this.id;
  }
  public double getBalance() {
    return balance;
  }
  
  
// Method to Get the Annual Interest Rate

  public double getAnnualInterestRate() {
    return annualInterestRate;
  }
  
// Method to Set Id

  public void setId(int id) {
    this.id =id;
  }

// Method to Set the Balance

  public void setBalance(double balance) {
    this.balance = balance;
  }
  
// Method to Set the Annual Interest Rate

  public void setAnnualInterestRate(double annualInterestRate) {
    this.annualInterestRate = annualInterestRate;
  }

// Method to Get the Monthly Interest

  public double getMonthlyInterest() {
    return balance * (annualInterestRate / 1200);
  }
  
// Method to Return Date Created

  public java.util.Date getDateCreated() {
    return dateCreated;
  }

// Do the Math for the Balance After Withdrawl

  public void withdraw(double amount) {
    balance -= amount;
  }

// Do the Math for the Balance After Deposit

  public void deposit(double amount) {
    balance += amount;
  }
}

// End Code. Huzzah!


