import java.util.Scanner;

public class ElectricityBill {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter the number of units consumed: ");
        int units = scanner.nextInt();
        scanner.close();

        double billAmount = calculateBill(units);
        System.out.println("The electricity bill for " + units + " units is: $" + billAmount);
    }

    public static double calculateBill(int units) {
        double billAmount = 0;

        if (units <= 100) {
            billAmount = units * 5;
        } else if (units <= 200) {
            billAmount = 100 * 5 + (units - 100) * 6;
        } else if (units <= 300) {
            billAmount = 100 * 5 + 100 * 6 + (units - 200) * 7;
        } else {
            billAmount = 100 * 5 + 100 * 6 + 100 * 7 + (units - 300) * 8;
        }

        return billAmount;
    }
}
