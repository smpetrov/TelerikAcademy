/*
 * Write an expression that checks if given positive integer 
 * number n (n ≤ 100) is prime. E.g. 37 is prime.
 * От математиката се знае , че трябва да проверим дали 
 * някое от числата от 2 до корен квадратен от чеслото 
 * дели числото без остатък   
*/
import java.util.Scanner;
public class PrimeInteger {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		double value = input.nextDouble();
        int endDivider = (int)Math.sqrt(value);
        input.close();
        int divider = 2;
        boolean yesPrime = true;
        while (yesPrime && (divider <= endDivider)) {
            if (value % divider == 0) {
                yesPrime = false;
            }
            divider++;
        }
        System.out.printf("Is %s prime ? = %s %n", value, yesPrime);
	}

}
