public class HalfOfIndexArray
{
	public static void main(String[] args) 
	{
	int[] arr={1,2,3,4,5,6,7,8,9,10};
	int mid=arr.length/2;
	int sumof1st_Half=0;
	int sumof2nd_Half=0;
	for(int i=0; i< mid ;i++)
	{
		sumof1st_Half+=arr[i];
	}	
	for(int i=mid;i<arr.length;i++)
	{
		sumof2nd_Half +=arr[i];
	}
	System.out.println(sumof1st_Half);
	System.out.println(sumof2nd_Half);
	}
}