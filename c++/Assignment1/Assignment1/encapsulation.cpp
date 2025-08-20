#include<iostream>
using namespace std;

class Car
{
private:
	string make;
	string model;
	int year;
	int speed;



public:
	Car(string carMake, string carModel, int carYear)
	{
		make = carMake;
		model = carModel;
		year = carYear;
		speed = 0;


	}


	string getMake()
	{
		return make;
	}
	string getModel()
	{
		return model;
	}

	int getYear()
	{
		return year;
	}

	int getspeed()
	{
		return speed;
	}



	void setMake(string carMake)

	{
		make = carMake;
	}
	void setModel(string carModel)
	{
		model = carModel;
	}
	void setYear(int carYear)
	{
		year = carYear;
	}

	void accelarate(int amount)
	{
		if (amount > 0)
		{
			speed += amount;
		}
		else
		{
			cout << "accelaration amount must be positive " << endl;
		}
	}

	void brake(int amount)
	{
		if (amount > 0 && speed - amount >= 0)
		{
			speed -= amount;
		}
		else
		{
			cout << "braking amount must be positive and not reduce speed below 0" << endl;
		}

	}
};

int main()
{
	Car mycar("Toyota", "corolla", 2022);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     

		cout<< " Make:"<<mycar.getMake(),                                                                                                                                                                                                                                                                                       ake() << ", Model: " << mycar.getModel()
		<< ", Year:" << mycar.getYear() << ", speed : " << mycar.getspeed() << "km/h" << endl;


		mycar.accelarate(30);
	cout << "Speed after acceleration: " << mycar.getspeed() << " km/h" << endl;

	mycar.brake(10);
	cout << "Speed after braking: " << mycar.getspeed() << " km/h" << endl;

	return 0;
}

		
		
		
		
		
		
		
		
		
		
		
		
		
	