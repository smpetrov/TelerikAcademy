/*
 * Write a program that gets a number n and after that gets more n 
 * numbers and calculates and prints their sum. 
*/
import java.util.Scanner;
public class SunNAferNNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Input n : ");
        int n = input.nextInt();
        int currentDigit;
        long sum = 0;
        for (int j = 1; j <= 2; j++) {

            for (int i = 1; i <= n; i++) {
            	System.out.printf("From unit %d input number %d : ", j , i);
                currentDigit = input.nextInt();
                sum = sum + currentDigit;
            }
        }
        input.close();
        System.out.print("Sum = " + sum);
	}

}
