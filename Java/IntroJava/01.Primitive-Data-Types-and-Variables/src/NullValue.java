/*
 *Create a program that assigns null values to an integer and to double variables. 
 *Try to print them on the console, try to add some values or the null literal to them and see the result.
 */
public class NullValue {

	public static void main(String[] args) {
		int a = 0;//null;
        double b = 0;//null;
        System.out.println(a);
        System.out.println(b);
        a = a + 5;
        b = b + 5.3;
        System.out.println(a);
        System.out.println(b);
	}

}
