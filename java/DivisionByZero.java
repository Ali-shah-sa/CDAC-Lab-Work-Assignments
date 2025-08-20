import java.util.Scanner;

public class DivisionByZero {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        try {
            System.out.print("Enter the first integer (numerator): ");
            int numerator = scanner.nextInt();

            System.out.print("Enter the second integer (denominator): ");
            int denominator = scanner.nextInt();

            int result = numerator / denominator;
            System.out.println("The result of the division is: " + result);

        } catch (ArithmeticException e) {
            System.out.println("Error: Division by zero is not allowed.");

        } finally {
            System.out.println("Division operation is complete.");
        }

        scanner.close();
    }
}
