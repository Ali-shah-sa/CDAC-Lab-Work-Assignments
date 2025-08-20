import java.util.*;
class Positive{
	public static void main(String[] args){
		/*Scanner s = new Scanner(System.in);

		System.out.println("Enter a number: ");
		int n = s.nextInt();*/

		int n=Integer.parseInt(args[0]);
		if(n > 0)
		{
			System.out.println( "The number " + n + "is a positive integer ");
		}
		else if(n < 0)
		{
			System.out.println("The number " + n + " is a negative integer ");
		}
		else 
		{
			System.out.println("It is a zero.");
		}

	}
}