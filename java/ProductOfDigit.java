import java.util.*;
public class ProductOfDigit
{
    public static int productOfDigits(int number)
     {
        int product = 1;
        while (number > 0) {
            int digit = number % 10;
            product *= digit;
            number /= 10;
        }
        return product;
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter a number: ");
        int number = scanner.nextInt();
        System.out.println("The product of the digits of " + number + " is " + productOfDigits(number));
    }
}



