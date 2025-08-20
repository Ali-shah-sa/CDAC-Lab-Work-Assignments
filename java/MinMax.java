public class MinMax
{
	public static void main(String[] args) 
	{
		int[] arr=new int[11];
		for(int i=0; i<arr.length;i++)
			arr[i]=(int)(Math.random()*90)+12;
		for(int i:arr)
		{
			System.out.print(i+" ");
		}
		int min =arr[0];
		int max =arr[0];
		for(int i=0;i<2;i++)
		{
			if(arr[i]<min)
				min=arr[i];
			if(arr[i]>max)
				max=arr[i];

		}
		System.out.println("\n Min: "+min+ " Max: "+max);
		
	}
}