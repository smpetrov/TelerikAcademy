/*
 * Write a program to calculate the sum (with accuracy of 0.001): 
 * 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
*/
import java.math.BigDecimal;
import java.math.MathContext;
import java.math.RoundingMode;
public class CalculateSumWithAccuracy {

	public static void main(String[] args) {
		BigDecimal sum = new BigDecimal("1");
        int divider = 2;
        while ((1.0/divider) >= 0.001) {
            if (divider % 2 == 0) {
                sum = sum.add(BigDecimal.valueOf(1.0 / divider));
            }
            else {
            	sum = sum.add(BigDecimal.valueOf(-1.0 / divider));
            }
            divider++;
        }
        System.out.println("Sum = " + sum.round(new MathContext(4,RoundingMode.HALF_UP)));
	}

}
