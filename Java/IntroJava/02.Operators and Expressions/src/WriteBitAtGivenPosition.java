/*
 * Write an expression that extracts from a given integer i 
 * the value of a given bit number b. Example: i=5; b=2  value=1.
*/
import java.util.Scanner;
public class WriteBitAtGivenPosition {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int i = input.nextInt();
        int b = input.nextInt();
        input.close();
        int mask = 1 << b;
        int bit = (i & mask) >> b;
        System.out.println("The " + b + " bit is " + bit);
	}

}
