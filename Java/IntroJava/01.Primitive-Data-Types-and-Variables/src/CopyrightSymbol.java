/*
 * Write a program that prints an isosceles triangle of 9 copyright symbols �. 
 * Use Windows Character Map to find the Unicode code of the � symbol. 
 * Note: the � symbol may be displayed incorrectly.
 */
public class CopyrightSymbol {

	public static void main(String[] args) {
		//Console.OutputEncoding = Encoding.UTF8;
		//System.out.
        char a='\u00a9';
        System.out.println(" " + " " + " " + a);
        System.out.println(" " +  " " + a + " " + a);
        System.out.println(" " +  a + " " + " " + " " + a );
        System.out.println(a + " " + a + " " + a + " " + a );
	}

}
