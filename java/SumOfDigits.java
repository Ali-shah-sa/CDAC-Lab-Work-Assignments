public class SumOfDigits {
	public static void main(String[] args) {
		int num=1234567;
		//int num=Integer.parseInt(args[0]);
		System.out.println("Single Digit Sum " + num + "  is "  +  singleDigitSum( num));
	} 
	public static int singleDigitSum(int num){
		while(num>10){
			num = SumOfDigits(num);
		}
		return num;
	}
	public static int SumOfDigits(int num){
		int sum = 0;
		while(num > 0){
			sum +=num%10;
			num/=10;
		}
		return sum;
	}
}