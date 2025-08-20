public class SumofCube{
	public static void main(String[] args) {
		int sum=0;
		for(int i=1;i<=100; i++){
			sum+=Math.pow(i,3);
		}
	
	System.out.println(+sum);
	}
}