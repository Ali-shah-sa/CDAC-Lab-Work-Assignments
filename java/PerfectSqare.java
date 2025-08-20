public class PerfectSqare {
	public static void main(String[] args) {
		//int num=16;
		int num = Integer.parseInt(args[0]);
        System.out.println(isPerfectSquare(num));
	}
	public static boolean isPerfectSquare(int num) {
		int sqrt =(int) Math.sqrt(num);
		return sqrt * sqrt ==num;
	}
}