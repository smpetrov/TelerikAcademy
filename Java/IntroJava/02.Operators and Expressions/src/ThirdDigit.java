/*
 * Write an expression that checks for given integer 
 * if its third digit (right-to-left) is 7. E. g. 1732  true.
*/
import java.util.Scanner;
public class ThirdDigit {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);  
		int x = input.nextInt();
		input.close();
		int result = (x / 100) % 10;
        if (result == 7)
        {
            System.out.println("Third digit is 7");
        }
        else
        {
        	System.out.println("Third digit is not 7");
        }

        // another way
        String b = Integer.toString(x);
        if (b.indexOf("7") == (b.length()-3))
        {
            System.out.println("Third digit is 7");
        }
        else
        {
        	System.out.println("Third digit is not 7");
        }
	}

}
