/*
 * Write a program that reads an integer number n from the console
 * and prints all the numbers in the interval [1..n], each on a single line.
*/
import java.util.Scanner;
public class PrintEachNubmerOnSingleLine {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Input n : ");
        int n = input.nextInt();
        input.close();
        for (int i = 1; i <= n; i++) {
        	System.out.println(i);
        }
	}

}
