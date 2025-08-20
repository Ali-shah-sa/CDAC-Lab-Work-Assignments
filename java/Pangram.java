public class Pangram
{
	public static boolean isPangram(String str) 
	{
		str=str.toLowerCase();
		for(char ch='a';ch<='z';ch++)
		{
			if(!str.contains(String.valueOf(ch)))
			{
				return false;
			}
		
		}	return true;
		
	}
	public static void main(String[] args)
	{
	 String test = "The quick brown fox jumps over the lazy dog";
	 System.out.println(isPangram(test));
}
}