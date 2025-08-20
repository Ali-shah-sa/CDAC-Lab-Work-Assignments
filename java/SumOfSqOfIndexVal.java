public class SumOfSqOfIndexVal 
{
public static void main(String[] args) 
{
	int[] arr={1,2,3,4,5,6,7,8,9};
	int sum=0;
	for(int i=1;i<arr.length;i+=2)
	{
		sum += arr[i] * arr[i];
	}
	        System.out.println("Sum of squares of values at odd indices: " + sum);
}
}