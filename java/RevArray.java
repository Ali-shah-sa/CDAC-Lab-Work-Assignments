public class RevArray
{
	public static void main(String[] args) 
	{
		int[]array=new int[20];
		for(int i=0;i<array.length;i++)
			array[i]=(int)(Math.random()*50)+10;
		for(int i:array)
		{
			System.out.print(i+" ");
		}
		System.out.println("\n**********************************************");
		int n=array.length;
		for(int i=0;i< n/2; i++)
		{
			int temp=array[i];
			array[i]=array[n- i -1];
			array[n - i -1]=temp;
		}
		for(int i :array)
		{
			System.out.print(i+" ");
		}
		
	}
}