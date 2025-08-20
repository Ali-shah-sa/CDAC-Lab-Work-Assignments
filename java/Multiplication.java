import java.util.*;
public class Multiplication
{
	public static void main(String[] args) 
	{
		Scanner sc = new Scanner(System.in);
		System.out.println("Enter a number : ");
		int a = sc.nextInt();
		//int multi =0;
		for(int i=1; i<=10 ; i++)
		{
			int multi = a * i ;

		
		System.out.println(a+ "  x " + i + " = "  +multi);
		}
	}
}






// (a + " x " + i + " = " + multi)