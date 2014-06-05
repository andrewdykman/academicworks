import java.util.*;
import java.text.*;

class Prime_number {
	public static boolean isPrime(int num)
{       boolean prime = true;
        for (int i = 3; i <= Math.sqrt(num); i += 2)
        if (num % i == 0)
        {  
            prime = false;
            break;
          }
        if (( num%2 !=0 && prime && num > 2) || num == 2)
         {        
             return true;     
	         }
	         else
	         {        
	             return false;
	         }
	   
	}
 public static void main (String[] args)
{
 
int num = 0;
int linecounter = 0;
for (int j = 0; j < 1000;){
num++;
if ( isPrime(num)){
 System.out.print(num);
 System.out.print("  ");
 linecounter++;
 j++;
if (num < 10){
 System.out.print("   ");
 }
if (num < 100 && num > 10){
 System.out.print("  ");
 }
if (num < 1000 && num > 100){
System.out.print(" ");
}
if (linecounter == 9){
linecounter = 0;
System.out.println("");
}
} 
}
}
  
 
}