class TrafficLight {
	public static void main(String[] args) {
		
		char a = args[0].charAt(0);

		switch(a){
		case 'r': System.out.println("Stop !");
			break;
		case 'y': System.out.println("Wait..");
			break;
		case 'g': System.out.println("Gooo");
			break;
		case 'R': System.out.println("Stop !");
			break;
		case 'Y': System.out.println("Wait..");
			break;
		case 'G': System.out.println("Gooo");
			break;
		default: System.out.println("Wrong Input !");
		}
	}
}