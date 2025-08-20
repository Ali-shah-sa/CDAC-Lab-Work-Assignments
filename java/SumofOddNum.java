public class SumofOddNum {
	public static void main(String[] args) {
		int sum=0;
		for(int i=1; i<=50 ;i++){
			if(i%2 !=0 ){
			sum+=i;
		}
	}
        System.out.println("Sum of odd numbers from 1 to 50: " + sum);
    }
}