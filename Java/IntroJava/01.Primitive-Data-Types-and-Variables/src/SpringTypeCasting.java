/*
 * Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of 
 * the first two variables (mind adding an interval). Declare a third string variable and initialize it with the value of the object variable
 * (you should perform type casting).
 */
public class SpringTypeCasting {

	public static void main(String[] args) {
		String str1 = "Hello";
        String str2 = "world";
        Object obj = str1 + " " + str2;
        String str3 = (String)obj;
        System.out.println(obj);
        System.out.println(str3);
	}

}
