import java.util.*;
public class IncomeTax
{
	public static void main(String[] args) 
	{
		System.out.println("Income_Tax Calculation");
		Scanner sc=new Scanner(System.in);
		
		//int ch;
		System.out.println("Enter Annual Income:");
		double income=sc.nextDouble();
		if(income <=250000)
		{
			System.out.println("No Tax Applied!" );
		}
			
	
		else if(income<=500000)
		{
			System.out.println("Tax Applied: 5% ");
			System.out.println("Income Tax Payable: " +(income * 0.05));
		}
				
		else if(income<=1000000)
		{
			System.out.println("Tax Applied: 20% ");
			System.out.println("Income Tax Payable: " +(income * 0.20));
		}
		else
		{

			System.out.println("Tax Applied: 30% ");
			System.out.println("Income Tax Payable: " +(income * 0.30));
		}
			
	}
	}