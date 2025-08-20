public class Bill
{
	public static void main(String[] args) 
	{
		double bill_amount = 35.10;
		double tip_percent = 15.00;
		double tip_amount = ((bill_amount) * (tip_percent/100));
		System.out.println("Bill Amount : "+bill_amount);
		System.out.println("Tip % : "+tip_percent);
		System.out.println("Tip Amount : $"+tip_amount);
		
	}

}