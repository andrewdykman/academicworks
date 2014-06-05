// Andrew Dykman, Java II, Lab 2.2
// Reading of Serialization of Test Scores in a Double Array

// Begin Code
import java.io.*;

public class TestScoreReadSerialization {
public static void main(String args[])
{
try {
ObjectInputStream in = new ObjectInputStream(new FileInputStream("test.ser"));
double[] array = (double[]) in.readObject();
in.close();
System.out.print("Test Scores (from Binary Data File Test.Ser): ");
for (int i=0; i<array.length; i++) {
System.out.print(array[i] + ", ");
}
}
catch (Throwable e) {
System.err.println("exception thrown");
}}}
// End Code. Huzzah!