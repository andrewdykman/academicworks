// Andrew Dykman, Java Lab 2
// FileArray Class
/** The write array method writes a char array to a file. **/

// Begin Code
import java.io.*;
public class FileArray{

// The write array method writes a char array to a file.

	public static void writeArray(String filename, char[] array)throws IOException{
		ObjectOutputStream output = new ObjectOutputStream(new FileOutputStream(filename, true));
		output.writeObject(array);
		output.close();
		}
		
	// The readArray method reads char from a file int a char array
	public static char[] readArray(String filename) throws IOException, ClassNotFoundException{
	ObjectInputStream input = new ObjectInputStream(new FileInputStream(filename));
		char[] array = (char[])(input.readObject());
		input.close();
		return array;
	}
}

// End Code. Huzzah!