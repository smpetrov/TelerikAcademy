/*
 * Write a program that reads two positive integer numbers and prints 
 * how many numbers p exist between them such that the reminder of 
 * the division by 5 is 0 (inclusive). Example: p(17,25) = 2.
*/
import java.util.Scanner;
public class NumbersDivideBy5 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Input first digit : ");
        int firstDigit = input.nextInt();
        System.out.print("Input second digit : ");
        int secondDigit = input.nextInt();
        input.close();
        int numberDivided5 = 0;
        for (int i = firstDigit; i <= secondDigit; i++) {
            if ((i % 5) == 0) {
                numberDivided5++;
            }
        }
        System.out.println("Number of digits divided by 5 without reminder is " + numberDivided5);
	}

}
