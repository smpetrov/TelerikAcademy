import java.text.DecimalFormat;
import java.text.DecimalFormatSymbols;
import java.util.Scanner;

/*
 * Write an expression that calculates rectangle’s area by given width and height.
*/
public class RectangleArea {

	public static void main(String[] args) {
		//DecimalFormatSymbols formatSimbols = new DecimalFormatSymbols(); 
		//formatSimbols.setDecimalSeparator('.');
		DecimalFormat decFormat =  new DecimalFormat("#.##");
		Scanner input = new Scanner(System.in);  
		double width = input.nextDouble();
        double height = input.nextDouble();
        input.close();
        double area = width * height;
        System.out.println("Rectangle area is : "+decFormat.format(area));
	}

}
