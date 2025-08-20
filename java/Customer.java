class Customer
{
	private int cusId;
	private String name;
	protected double balance;
	static String bank="SBI";

	Customer(int i,String n,double b)
	{
		cusId=i;
		name=n;
		balance=b;
	}

	void display()
	{
    System.out.println(cusId+ " "+name+" "+balance+" "+bank);
	}

	void calculateInt()
	{
    double roi=8.5;
    int t=2;
    double simpleInt =(balance*roi*t)/100;
    System.out.println(simpleInt);
	}

    public static void main(String[] args) {
    Customer c1 = new Customer(123,"RXZY",15000);
    c1.display();
    c1.calculateInt();

    ClassicCustomer c2 = new ClassicCustomer(332,"lisa",66000,5000,11.7);
    c2.display();
    c2.calculateInt();
    }
}