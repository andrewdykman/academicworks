// Andrew Dykman, Lab 1.2 - Java II

// Begin Code
public class InvalidTestScore extends Exception{

  public InvalidTestScore(){
    super("Error, Score Invalid");
  }
  public InvalidTestScore(int index, double scores){
    super("Error, Score Invalid: " + scores);
  }
}
// End Code. Huzzah!