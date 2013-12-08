/*
 * Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
*/
import java.util.Scanner;
public class PointInCircle {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int x = input.nextInt();
        int y = input.nextInt();
        input.close();
        int radius = 5;
        if ((x*x + y*y)<radius*radius) {
            System.out.println("Point (" + x + "," + y + ") is in the circle");
        }
        else {
        	System.out.println("Point (" + x + "," + y + ") is not in the circle");
        }
	}

}
