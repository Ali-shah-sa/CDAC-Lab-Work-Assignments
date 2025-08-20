public class SearchElement
{
	public static void main(String[] args) 
	{
		int[] array=new int[50];
		for(int i=0;i<array.length;i++)
			array[i]=(int)(Math.random()*99)+12;
		for(int i:array)
		{
			System.out.print(i+" ");
		}

		int x=(int) (Math.random()*30)+1;
		System.out.println("\n Searching for : "+x);
		boolean flag=false;
		for(int i=0;i<array.length;i++)
		{
			if(x==array[i])
			{
				System.out.println(x+" is found at index:"+i);
				flag=true;
				break;
			}
		}
		if(flag==false)
			System.out.println(x+" is not found in array");
		
	}
}