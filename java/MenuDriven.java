import java.util.*;

class MenuDriven {

    static int factorial(int n) {
        int fact = 1;
        for (int i = 1; i <= n; i++)
            fact = fact * i;

        return fact;
    }

    static void strongNumber(int n) {
        int x = n;
        int sum = 0;

        while (n > 0) {
            int d = n % 10;
            sum = sum + factorial(d); // getting factorial of d
            n = n / 10;
        }

        if (sum == x)
            System.out.println(x + " is Strong Number");
        else
            System.out.println(x + " is not Strong number");
    }

    static void fibonacci(int n) {
        int a = 0;
        int b = 1;
        System.out.println("Printing Fibonacci Series:");
        System.out.print(a + "\t" + b + "\t");
        int terms = 2;
        while (terms <= n) {
            int c = a + b;
            System.out.print(c + "\t");
            a = b;
            b = c;
            terms++;
        }
    }

    static boolean isPrime(int n) {
        if (n <= 1)
            return false;
        for (int i = 2; i <= Math.sqrt(n); i++) {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    static void primeNumber(int n) {
        if (isPrime(n))
            System.out.println(n + " is a Prime Number");
        else
            System.out.println(n + " is not a Prime Number");
    }

    static boolean isArmstrong(int n) {
        int x = n;
        int sum = 0;
        while (n > 0) {
            int d = n % 10;
            sum += d * d * d;
            n = n / 10;
        }
        return sum == x;
    }

    static void armstrongNumber(int n) {
        if (isArmstrong(n))
            System.out.println(n + " is an Armstrong Number");
        else
            System.out.println(n + " is not an Armstrong Number");
    }

    static void reverseNumber(int n) {
        int reverse = 0;
        while (n != 0) {
            int digit = n % 10;
            reverse = reverse * 10 + digit;
            n = n / 10;
        }
        System.out.println("Reversed Number: " + reverse);
    }

    static boolean isPerfect(int n) {
        int sum = 0;
        for (int i = 1; i <= n / 2; i++) {
            if (n % i == 0)
                sum += i;
        }
        return sum == n;
    }

    static void perfectNumber(int n) {
        if (isPerfect(n))
            System.out.println(n + " is a Perfect Number");
        else
            System.out.println(n + " is not a Perfect Number");
    }

    static boolean isPalindrome(int n) {
        int original = n;
        int reverse = 0;
        while (n != 0) {
            int digit = n % 10;
            reverse = reverse * 10 + digit;
            n = n / 10;
        }
        return original == reverse;
    }

    static void palindrome(int n) {
        if (isPalindrome(n))
            System.out.println(n + " is a Palindrome Number");
        else
            System.out.println(n + " is not a Palindrome Number");
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int choice;

        do {
            System.out.println("****Menu Driven Program*****");
            System.out.println("1.Factorial\n2.Prime Number\n3.Armstrong\n4.Strong\n5.Reverse Number");
            System.out.println("6.Perfect Number\n7.Palindrome\n8.Fibonacci\n9.EXIT");

            System.out.println("\nEnter your choice");
            choice = scanner.nextInt();

            switch (choice) {
                case 1:
                    System.out.println("Enter a number");
                    int n1 = scanner.nextInt();
                    System.out.println("Factorial of " + n1 + " is: " + factorial(n1));
                    break;
                case 2:
                    System.out.println("Enter a number");
                    int n2 = scanner.nextInt();
                    primeNumber(n2); // check if n is prime
                    break;
                case 3:
                    System.out.println("Enter a number");
                    int n3 = scanner.nextInt();
                    armstrongNumber(n3); // check if n is armstrong
                    break;
                case 4:
                    System.out.println("Enter a number");
                    int n4 = scanner.nextInt();
                    strongNumber(n4); // check if n is strong
                    break;
                case 5:
                    System.out.println("Enter a number");
                    int n5 = scanner.nextInt();
                    reverseNumber(n5); // reverse the number
                    break;
                case 6:
                    System.out.println("Enter a number");
                    int n6 = scanner.nextInt();
                    perfectNumber(n6); // check if n is perfect
                    break;
                case 7:
                    System.out.println("Enter a number");
                    int n7 = scanner.nextInt();
                    palindrome(n7); // check if n is palindrome
                    break;
                case 8:
                    System.out.println("Enter number of terms to be printed...");
                    int n8 = scanner.nextInt();
                    fibonacci(n8); // generate Fibonacci series
                    break;
                case 9:
                    System.out.println("Thank you...");
                    break;
                default:
                    System.out.println("Please enter proper choice from the Menu");
            }
        } while (choice != 9);
    }
}
