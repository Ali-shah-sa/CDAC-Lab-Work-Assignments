public class Star
{
	public static void main(String[] args) 
	{
	for(int i=1;i<=10;i++)
	{
    for(int j=10;j>i;j--)
    {
        System.out.println(" ");   
    }

    for(int k=1;k<=i;k++)
    {
        System.out.print("*");
    }

    for(int l=10;l<=1;l++)
    {
        for(int h=1;h<=10;h++)
        {
            System.out.print(" ");
        }
    }

    System.out.println();  
}
}
}