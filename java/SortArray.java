import java.util.Arrays;
public class SortArray
{
	public static void main(String[] args) 
	{
		int[]array= new int[20];
		for(int i=0;i<array.length;i++)
			array[i]=(int)(Math.random()*99)+12;
		for(int i:array)
		{
			System.out.print(i+" ");
		}
		System.out.println("\n**************");
		Arrays.sort(array);
		for(int i:array)
			System.out.print(i+" ");
	}
}