import java.util.*;

class Largest {
	
	public static void main(String[] args) {
		
		Scanner s = new Scanner(System.in);

		System.out.println("Enter 1st no- ");
		int a = s.nextInt();
		System.out.println("Enter 2nd no- ");
		int b = s.nextInt();
		System.out.println("Enter 3rd no- ");
		int c = s.nextInt();

		if (a>=b && a >= c)
		{
			System.out.println("Largest number is - " + a);
		}
		else if (b>=c && b>=a)
		{
			System.out.println("Largest number is - " + b);
		}
		else{
			System.out.println("Largest number is - " + c);
		}

	}
}