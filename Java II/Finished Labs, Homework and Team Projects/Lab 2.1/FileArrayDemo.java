 // Andrew Dykman, Lab 2

// Begin Code
 
 import java.io.*;

   public class FileArrayDemo {
      public static void main(String[] args) {
         char[] letters = {'a', 'b', 'c', 'd', 'e', 'f'};
         try{
            FileArray filearray = new FileArray();
            filearray.writeArray("MyLetters.txt", letters);
            char[] test = filearray.readArray("MyLetters.txt");
            System.out.println("The characters read from the file are: ");
            for(int i=0; i<test.length; i++)
               System.out.print(test[i] + " ");
            System.out.println();
         }
            catch(IOException e){
               System.out.println("Error = " + e.getMessage());
            }
            catch(ClassNotFoundException e){
               System.out.println("Error = " + e.getMessage());
            }
      
      
      }
   
   }
	
// End Code. Huzzah!