import java.util.*;
public class Factorial
{
	public static void main(String[] args) 
	{
		Scanner sc = new Scanner(System.in);

		System.out.println("Enter any positive number : ");
		int a= sc.nextInt();
		System.out.println("Factorial of " + a + " is " + factor);


		long factor =1;

        for(int i=0; i<=a; i++)
        {
        	factor *=i;  //(factor=factor*i)
        }
        System.out.println("Factorial of " + a + " is " + factor);

	}

	




}






















