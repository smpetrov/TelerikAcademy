/*
 * We are given integer number n, value v (v=0 or 1) and a position p. 
 * Write a sequence of operators that modifies n to hold 
 * the value v at the position p from the binary representation of n.
 *Example: n = 5 (00000101), p=3, v=1  13 (00001101)
 *n = 5 (00000101), p=2, v=0  1 (00000001)
*/
import java.util.Scanner;
public class Write0Or1AtGivenPosition {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
        int v = input.nextInt();
        int p = input.nextInt();
        input.close();
        int mask = 1 << p;
        int result;
        if (v == 1) {
            result = n | mask;
            System.out.println("n = " + n + "  p = " + p + " v = " + v + " => " + result);
        }
        else if (v == 0) {
            result = n & (~mask);
            System.out.println("n = " + n + "  p = " + p + " v = " + v + " => " + result);
        }
        else {
            System.out.println("Wrong v / 0 or 1/ !!!");
        }	}

}
