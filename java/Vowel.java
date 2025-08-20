import java.util.*;

class Vowel {
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);

		System.out.println("Enter a Character : ");
		char c = s.next().charAt(0);

		if(c=='a'|| c== 'e' || c=='i' || c=='o' || c=='u' || c=='A' || c=='E' || c=='I' || c=='O' || c=='U')
		{
			System.out.println("It is a vowel");
		}
		else 
		{
			System.out.println("It is a consonant");
		}
	}
}