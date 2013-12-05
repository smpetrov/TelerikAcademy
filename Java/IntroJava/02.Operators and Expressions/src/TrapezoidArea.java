/*
 * Write an expression that calculates trapezoid's area by given 
 * sides a and b and height h.
 * /2.0 за да стане double резултата
*/
import java.util.Scanner;
public class TrapezoidArea {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int a = input.nextInt();
        int b = input.nextInt();
        int h = input.nextInt();
        input.close();
        System.out.println("Trapezoid's area is :" + ((a + b) * h / 2.0));
	}

}
