public class NullPointerExcep
 {
    public static void main(String[] args) {
        String str = null;

        try {
            System.out.println("to get the length of the string.");
            int length = str.length();
            System.out.println("String length: " + length);
        } 
        catch (NullPointerException e) {
            System.out.println("Error: NullPointerException");
        } 
        finally {
            System.out.println("Operation complete.");
        }
    }
}
