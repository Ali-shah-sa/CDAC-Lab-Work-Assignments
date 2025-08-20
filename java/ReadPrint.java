import java.util.*;
public class ReadPrint
{
	public static void main(String[] args) 
	{
		Scanner sc =new Scanner(System.in);
		System.out.println("Enter the number of elements in array: ");
		int n=sc.nextInt();
		int[]array=new int[n];
		System.out.println("the elements are: ");
		for(int i=0;i<n;i++)
		{
			array[i]=sc.nextInt();
		}


		
	}
}