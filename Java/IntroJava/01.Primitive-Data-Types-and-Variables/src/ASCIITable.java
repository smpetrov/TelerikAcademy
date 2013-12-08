/*
 * Find online more information about ASCII (American Standard Code for Information Interchange) 
 * and write a program that prints the entire ASCII table of characters on the console.
 */

public class ASCIITable {

	public static void main(String[] args) {
		for (int i = 0; i < 256; i++) {
            if (i % 25 == 0) {
            	System.out.println((char)i);
            }
            else {
            	System.out.println((char)i);
            }
        }
	}

}
