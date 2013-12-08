/*
 *Write a program that exchanges bits {p, p+1, …, p+k-1) 
 *with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.
*/
import java.util.Arrays;
import java.util.Scanner;
public class ExchangeSomeBitsPosition {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Input value x:");
        int x = input.nextInt();
        System.out.print("Input position to first area p:");
        int p = input.nextInt();
        System.out.print("Input position to second area q:");
        int q = input.nextInt();
        System.out.print("Input nubers of bits k:");
        int k = input.nextInt();
        input.close();
        if ((p + k < q) && (q > p)) {
        	//създаване на стринг запълнене със символ
        	char[] fill = new char[k];
        	Arrays.fill(fill,'1');
            //създаване на маската
            String strMask = new String(fill);
            //използваме mask като маска
            //00000000000000000000000000000111 = 7
            int mask = Integer.parseInt(strMask);
            int maskPositionP = mask << p;
            int maskPositionQ = mask << q;
            //вземаме битовете то позиции 3,4,5 и 24,25,26
            int bitFromPosotionP = (x & maskPositionP) >> p;
            int bitFromPositionQ = (x & maskPositionQ) >> q;
            int exchangeBitToPositionP;
            int exchangeBitToPositionQ;
            //нулираме битовете на позиции 3,4,5 и 24,25,26
            x = x & (~maskPositionP);
            x = x & (~maskPositionQ);
            //разменяме битовете на позиции 3,4,5 и 24,25,26
            exchangeBitToPositionP = bitFromPositionQ << p;
            exchangeBitToPositionQ = bitFromPosotionP << q;
            x = x | exchangeBitToPositionP;
            x = x | exchangeBitToPositionQ;
            System.out.print("After exchange bits 3,4,5 with 24,25,26 = " + x);
        }
        else {
        	System.out.print("Wrong input area");
        }
	}

}
