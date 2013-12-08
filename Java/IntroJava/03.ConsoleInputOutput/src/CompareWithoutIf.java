
import java.util.Scanner;
public class CompareWithoutIf {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Input first digit : ");
        int firstDigit = input.nextInt();
        System.out.print("Input second digit : ");
        int secondDigit = input.nextInt();
        input.close();
        System.out.println("The greater digit is " + 
            ((firstDigit > secondDigit) ? firstDigit : secondDigit ));
	}
}
