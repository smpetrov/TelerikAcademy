/*
 * A marketing firm wants to keep record of its employees. 
 * Each record would have the following characteristics – first name, family name, age, gender (m or f), 
 * ID number, unique employee number (27560000 to 27569999). Declare the variables needed to keep the information 
 * for a single employee using appropriate data types and descriptive names.
 */

public class EmployeeRecord {

	public static void main(String[] args) {
		String firstName = "Ivan";
        String lastName = "Ivanov";
        byte age= 25;
        char gender = 'm';
        int IDNumber = 1000;
        System.out.println(firstName+" "+lastName);
        System.out.println("ID number: "+IDNumber);
	}

}
