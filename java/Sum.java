public class Sum
{
	public static void main(String[] args) 
	{
	 int n = 1+(int) (Math.random()*1000);
	 System.out.println("generated number is : " +n);
	 int sum =0;
	 while (n>0)
	 {
	 	    sum += n % 10;
            n/= 10;
	 }

	  System.out.println("Sum of Digits: " + sum);
	}
}


























































/*public class Sum
{
	public static void main(String[] args) 
	{
			int sum=0;
		for(int i=1;i<=100;i++)
		{
	
		sum +=i ;
	}
		System.out.println(sum);
		
	}
}*/