public class ArrIndExcep
 {
    public static void main(String[] args) {
        
        int[] numbers = {1, 2, 3, 4, 5};

        try {
            System.out.println("Accessing an invalid index: " + numbers[10]);
        } 
        catch (ArrayIndexOutOfBoundsException e) {
            
            System.out.println("Error: Index out of bounds");
        } 
        finally {
            System.out.println("Operation complete.");
        }
    }
}
