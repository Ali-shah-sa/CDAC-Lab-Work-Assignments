import java.util.Scanner;

public class IncomeTaxCalculator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter your annual salary: $");
        double annualSalary = scanner.nextDouble();
        scanner.close();

        double taxAmount = calculateTax(annualSalary);
        System.out.println("The income tax payable on an annual salary of $" + annualSalary + " is: $" + taxAmount);
    }

    public static double calculateTax(double annualSalary) {
        double taxAmount = 0;

        if (annualSalary <= 250000) {
            taxAmount = 0;
        } else if (annualSalary <= 500000) {
            taxAmount = (annualSalary - 250000) * 0.05;
        } else if (annualSalary <= 1000000) {
            taxAmount = (annualSalary - 500000) * 0.20 + 250000 * 0.05;
        } else {
            taxAmount = (annualSalary - 1000000) * 0.30 + 500000 * 0.20 + 250000 * 0.05;
        }

        return taxAmount;
    }
}
