class ConstOverPerson
{
    private String name;
    private int age;
    private String country;

    public ConstOverPerson() {
        this.name = "Unknown";
        this.age = 0;
        this.country = "Unknown";
    }

    public ConstOverPerson(String name, int age, String country) {
        this.name = name;
        this.age = age;
        this.country = country;
    }

    public void displayDetails() {
        System.out.println("Name: " + name);
        System.out.println("Age: " + age);
        System.out.println("Country: " + country);
    }

    public static void main(String[] args) {
        ConstOverPerson person1 = new ConstOverPerson();
        ConstOverPerson person2 = new ConstOverPerson("Emily", 25, "Canada");

        System.out.println("ConstOverPerson 1 Details:");
        person1.displayDetails();

        System.out.println("\nPerson 2 Details:");
        person2.displayDetails();
    }
}
