/*
 * Write a program to print the first 100 members of the sequence of 
 * Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
 * Редичата на Фибуначи започва се с 1 и 1, а всеки следващ член на редицата 
 * се получава като сума на предходните два
*/
import java.math.BigDecimal;
public class EquenceOfFibunacci {

	public static void main(String[] args) {
		//Scanner input = new Scanner(System.in);
		//System.out.print("Input number: ");
        //int number = input.nextInt();
		//input.close();
		
        int number = 100;
        BigDecimal temporaryValue = new BigDecimal("0.0");

        System.out.println(0);
        BigDecimal previousValue = new BigDecimal("1");
        System.out.println(1);
        BigDecimal currentValue = new BigDecimal("1");
        System.out.println(1);
        for (int i = 1; i <= number - 3; i++) {
            System.out.println(previousValue.add(currentValue));
            temporaryValue = previousValue;
            previousValue = currentValue;
            currentValue = currentValue.add(temporaryValue);
        }
	}

}
