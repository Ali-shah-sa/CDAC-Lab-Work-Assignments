import java.util.*;

public class GradingSystem {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter the number of subjects: ");
        int numberOfSubjects = scanner.nextInt();

        double[] percentages = new double[numberOfSubjects];
        for (int i = 0; i < numberOfSubjects; i++) {
            System.out.print("Enter percentage for subject " + (i + 1) + ": ");
            percentages[i] = scanner.nextDouble();
        }
        scanner.close();

        double averagePercentage = calculateAveragePercentage(percentages);
        char grade = calculateGrade(averagePercentage);

        System.out.println("The average percentage is: " + averagePercentage + "%");
        System.out.println("The grade based on the average percentage is: " + grade);
    }

    public static double calculateAveragePercentage(double[] percentages) {
        double total = 0;
        for (double percentage : percentages) {
            total += percentage;
        }
        return total / percentages.length;
    }

    public static char calculateGrade(double percentage) {
        if (percentage >= 90) {
            return 'A';
        } else if (percentage >= 80) {
            return 'B';
        } else if (percentage >= 70) {
            return 'C';
        } else if (percentage >= 60) {
            return 'D';
        } else {
            return 'F';
        }
    }
}
