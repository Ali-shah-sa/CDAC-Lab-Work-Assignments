import java.util.Random;
import java.util.*;

public class GuessTheNumber {
    public static void main(String[] args) {
        Random random = new Random();
        int randomNumber = random.nextInt(101); // Generates a random number between 0 and 100
        Scanner scanner = new Scanner(System.in);
        int guess = -1;

        System.out.println("I have generated a random number between 0 and 100. Can you guess what it is?");

        while (guess != randomNumber) {
            System.out.print("Enter your guess: ");
            guess = scanner.nextInt();

            if (guess < randomNumber) {
                System.out.println("Too low! Try again.");
            } else if (guess > randomNumber) {
                System.out.println("Too high! Try again.");
            } else {
                System.out.println("Congratulations! You guessed the correct number: " + randomNumber);
            }
        }
        scanner.close();
    }
}
