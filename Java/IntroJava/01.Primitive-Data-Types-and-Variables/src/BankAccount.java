/*
 * A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
 * bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables needed 
 * to keep the information for a single bank account using the appropriate data types and descriptive names.
 */
import java.math.BigDecimal;
public class BankAccount {

	public static void main(String[] args) {
        String lastName;
        String firstName;
        BigDecimal balance = new BigDecimal(1);
        BigDecimal divider = new BigDecimal(10);
        BigDecimal result = new BigDecimal(0);
        result = balance.divide(divider,7,BigDecimal.ROUND_FLOOR);
        double delimo = balance.doubleValue() / 3; 
        String middleName;
        String bankName;
        String IBAN;
        String BICCode;
        String cadrNumber1;
        String cadrNumber2;
        String cadrNumber3;
        System.out.println(result);
        BigDecimal balSum = new BigDecimal(0);
        for (int i =0; i<10; i++){
        	balSum = balSum.add(result);
        }
        System.out.println(balSum);
	}

}
