// Andrew Dykman, Lab 1.2 - Java II

// Begin Code
public class TestScores{
  private double[] scores;

  public TestScores(double[] s) throws InvalidTestScore{
    scores = new double[s.length];
   
    for (int i = 0; i < s.length; i++){
      if (s[i] < 0 || s[i] > 100)
          throw new InvalidTestScore();
    }
  }
  public double getAverage(){
    double total = 0.0;
    for (int i = 0; i < scores.length; i++)
      total += scores[i];
       
    return total/scores.length;
  }
}
// End Code. Huzzah!