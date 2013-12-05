/*
 * Write an expression that checks for given point (x, y) 
 * if it is within the circle K( (1,1), 3) and out of 
 * the rectangle R(top=1, left=-1, width=6, height=2).
*/
import java.util.Scanner;
public class PointInCircleOutOfRectangle {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int x = input.nextInt();
        int y = input.nextInt();
        input.close();
        boolean boolInRectangle = ((x >= -1) && (x <= 5)) && ((y <= 1) && (y >= -1));
        boolean boolInCircle = Math.sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 3;
        boolean boolResult = (boolInRectangle == false) && (boolInCircle == true);
        System.out.printf("The point in the area /cirle - rectangle/ = %s %n", boolResult);
	}

}
