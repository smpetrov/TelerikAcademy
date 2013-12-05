/*
 * Declare  two integer variables and assign them with 5 and 10 and after that exchange their values
 */
public class ExcangeValues {

	public static void main(String[] args) {
		byte a = 5;
        byte b = 10;
        byte c;
        System.out.println("a = " + a + " b = " + b);
        c = a;
        a = b;
        b = c;
        System.out.println("a = " + a + " b = " + b);
	}

}
