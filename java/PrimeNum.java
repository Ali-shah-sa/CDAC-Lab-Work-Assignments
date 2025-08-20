public class PrimeNum {
public static void main(String[] args) {
	int primeSum=0;
	for(int i=1; i<=100; i++)
	{
		if(isPrime(i))
		{
			primeSum+=i;
	}
}        System.out.println("Sum of prime numbers between 1 and 100: " + primeSum);
}
public static boolean isPrime(int n) {
	if(n<=1)
		return false;
	for(int i=2;i<=Math.sqrt(n); i++){
		if(n%i==0)
			return false;
	}
	return true;
}
}