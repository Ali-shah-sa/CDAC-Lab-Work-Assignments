class ClassicCustomer extends Customer
{
	int withdrawlimit;
	double newinterest;

    ClassicCustomer(int i,String n,double b, int w, double ni)
	{
		super(i,n,b);
		withdrawlimit=w;
		newinterest=ni;
	}

	void display()
	{
		super.display();
   		System.out.println("Withdrwaing : "+withdrawlimit+ " New interest : "+newinterest);
	}

	void calculateInt()
	{
		double simpleInt = (balance * newinterest * 2) / 100;  
        System.out.println("Calculated Simple Interest of Classic Customer : " + simpleInt);
	}

}