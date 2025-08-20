import java.util.*;

class EvenOdd{
	public static void main(String[] args) {
		
		Scanner s = new Scanner(System.in);

		System.out.println("Enter a number- ");

		int n = s.nextInt();

		if (n%2==0)
		{
			System.out.println("It is an even number.");
		}
		else 
		{
			System.out.println("It is a odd number.");
		}
	}
}