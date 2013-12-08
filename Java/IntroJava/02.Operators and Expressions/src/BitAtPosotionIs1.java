/*
 * Write a boolean expression that returns if the bit at 
 * position p (counting from 0) in a given integer 
 * number v has value of 1. Example: v=5; p=1  false.
*/
import java.util.Scanner;
public class BitAtPosotionIs1 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int v = input.nextInt();
        int p = input.nextInt();
        input.close();
        int mask = 1 << p;
        if ((v & mask) != 0) {
            System.out.println("The " + p + " bit is 1");
        }
        else {
        	System.out.println("The " + p + " bit is 0");
        }
        
        
        //another way
        int bit = v & mask;
        bit = bit >> p;
        System.out.println("The " + p + " bit is " + bit);
	}

}
