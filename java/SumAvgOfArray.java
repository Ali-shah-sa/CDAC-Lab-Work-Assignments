public class SumAvgOfArray 
{
	public static void main(String[] args) 
	{
		int[] arr=new int[10];
		for(int i=0;i<arr.length;i++)
			arr[i]=(int)(Math.random()*100)+10;
		int sum=0;

		for(int i:arr)
		{
			System.out.print(i+" ");
			sum+=i;
		}

		double avg=(double)sum/arr.length;
		System.out.println("\nSUM: "+sum+ "\tAVG: "+avg);
		
	}
}