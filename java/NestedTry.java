public class NestedTry
{
    public static void main(String[] args) 
    {
        try {
            System.out.println("Outer try block");
            try {
                System.out.println("Perform division");
                int num1 = 10;
                int num2 = 0; 
                int result = num1 / num2;
                System.out.println("Division Result: " + result);
            } 
            catch (ArithmeticException e) {
                System.out.println("Error: ArithmeticException! Division by zero is not allowed.");
            } 
            finally {
                System.out.println("1st nested try block");
            }
            try {
                System.out.println("Initializing array in the 2nd nested try.");
                int[] numbers = {1, 2, 3, 4, 5};
                System.out.println("Accessing an element at index 10: " + numbers[10]);
            } 
            catch (ArrayIndexOutOfBoundsException e) {
                System.out.println("Error: ArrayIndexOutOfBoundsException");
            } 
            finally {
                System.out.println("2nd nested try block complete.");
            }

        } 
        catch (Exception e) {
            System.out.println("An unexpected error occurred: " + e.getMessage());
        }
         finally {
            System.out.println("operation complete.");
        }
    }
}
