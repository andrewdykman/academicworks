// Andrew Dykman, Lab 1.2 - Java II

// Begin Code
public class TestScoresDemo{
  public static void main(String[] args){
    double[] badScores = {97.5, 66.7, 88.0, 101.0, 99.0 };
    double[] goodScores = {97.5, 66.7, 88.0, 100.0, 99.0 };
    try{
        TestScores bad = new TestScores(badScores);
        TestScores good = new TestScores(goodScores);
    }
    catch (InvalidTestScore e){
      System.out.println("Invalid score found.\n" + e.getMessage());
    }
    finally{
        try{
          TestScores good = new TestScores(goodScores);
          System.out.println(good.getAverage());
        }
        catch (InvalidTestScore e){
          System.out.println("Invalid score found.\n" + e.getMessage());
        }
    }
  }
}
// End Code. Huzzah!