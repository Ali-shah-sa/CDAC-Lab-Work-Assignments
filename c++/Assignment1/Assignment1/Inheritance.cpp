#include<iostream>
using namespace std;
class Animal
{
private:
	string name;
	int age;


public:
	Animal(string aname, int aage)
	{
		name = aname;
		age = aage;
	}


	virtual void makeSound()
	{
		cout << "Animal Make Sound" << endl;
	}
	void eat()
	{
		cout << "Eating" << endl;
	}
};

class Dog :public Animal
{
public:
	Dog(string aname, int aage) : Animal(aname, aage) {}
	void makeSound()
	{
		cout << "Boww Boww" << endl;
	}
	void Bark()
	{
		cout << "Boww Boww:" << endl;

	}
};
	
class Cat :public Animal

{
public:
	Cat(string aname, int aage) : Animal(aname, aage) {}
	void makeSound()
	{
		cout << "Meow Meow" << endl;
	}

	void Meow()
	{
		cout << "meow meow" << endl;

	}
};
int main()
{
	Dog d1("charlie",3);
	Cat c1("buddy", 2);
	Animal* animals[] = {&d1, &c1 };
	for (Animal* a : animals) 
	{
		a->makeSound();
		a->eat();
	}
	
	d1.Bark();
	c1.Meow();

	return 0;

}

