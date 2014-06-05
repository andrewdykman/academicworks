// Andrew Dykman, Lab 1 - Java II

// Begin Code

public class TestScoresDemo{
	public static void main(String[] args) {
		double[] badscores = {97.5, 66.7, 88.0, 101.0, 99.0};
		double[] goodscores = {97.5, 66.7, 88.0, 100.0, 99.0};
		
		try{
			TestScores bad = new TestScores(badscores);
			TestScores good = new TestScores(goodscores);
		
		}catch(IllegalArgumentException e){
			System.out.println("Invalid score found.\n" + e.getMessage());
		
		}finally{
			try{
				TestScores good = new TestScores(goodscores);
				System.out.println(good.getAverage());
			
			}catch(IllegalArgumentException e){
			System.out.println("Invalid score found.\n" + e.getMessage());
			
			}
		}
	}
}

// End Code. Huzzah!