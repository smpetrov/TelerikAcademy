/*
 * Write a boolean expression for finding if the bit 3 (counting from 0) 
 * of a given integer is 1 or 0.
*/
import java.util.Scanner;
public class WhatIsBit3 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);  
		int x = input.nextInt();
		input.close();
		int mask = 1 << 3;
        if ((x & mask) != 0)
        {
            System.out.println("The third bit is 1");
        }
        else
        {
        	System.out.println("The third bit is 0");
        }

        //another way
         int d = 16;
         int resultMove = 1 << 3;
         int resultAnd = d & resultMove;
         int bit = resultAnd >> 3;
         System.out.printf("bit is %s %s %n ",bit,bit==1);
	}

}
