/*
 * Write a program that reads the coefficients a, b and c of a 
 * quadratic equation ax2+bx+c=0 and solves it (prints its real roots).
*/
import java.util.Scanner;
public class RootsQuadraticEquation {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Input a : ");
        int a = input.nextInt();
        System.out.print("Input b : ");
        int b = input.nextInt();
        System.out.print("Input c : ");
        int c = input.nextInt();
        input.close();
        double Discriminant = b * b - 4 * a * c;
        if (Discriminant < 0) {
        	System.out.println("Quadratic equation dousn't have roots !");
        }
        else if (Discriminant == 0) {
        	System.out.println("Quadratic equation root =" + (-(b / (2 * a))));
        }
        else {
        	System.out.println("Quadratic equation root fist = " + 
                               ((b + Math.sqrt(Discriminant)) / (2 * a)));
        	System.out.println("Quadratic equation root second = " + 
                               ((b - Math.sqrt(Discriminant)) / (2 * a)));
        }
	}

}
