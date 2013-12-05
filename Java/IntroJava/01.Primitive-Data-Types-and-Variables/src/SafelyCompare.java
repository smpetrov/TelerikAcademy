/*
 * Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true
 */
public class SafelyCompare {

	public static void main(String[] args) {
		float a = 5.3F;
        float b = 6.01F;
        System.out.println(a == b);

        float c = 5.00000001F;
        float d = 5.00000003F;
        System.out.println(c == d);
	}

}
