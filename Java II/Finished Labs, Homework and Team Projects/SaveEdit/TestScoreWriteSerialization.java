// Andrew Dykman, Java II, Lab 2.2
// Writing of Seriaization of Test Scores in a Double Array

// Begin Code
import java.io.*;

public class TestScoreWriteSerialization {
public static void main(String args[]){
try {
ObjectOutputStream out = new ObjectOutputStream(new FileOutputStream("test.ser"));
out.writeObject(new double[] {97.5, 66.7, 88.0, 100.0, 99.0});
out.flush();
out.close();
}
catch (Throwable e) {
System.err.println("exception thrown");
}
}
}
// End Code. Huzzah!