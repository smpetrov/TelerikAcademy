/*
 * Write a program that reads the radius r of a circle and prints its 
 * perimeter and area.
*/
import java.util.Scanner;
public class CirclePerimeterArea {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Input radius of the circle: ");
        double radius = input.nextDouble();
        input.close();
        System.out.printf("Perimeter of circle = %-10.2f",(2 * Math.PI * radius));
        System.out.printf("Area of circle = %10.2f",(Math.PI * radius * radius));
	}

}