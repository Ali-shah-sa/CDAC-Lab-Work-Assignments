import javax.swing.JOptionPane;
public class QuizQuestion
{
	public static void main(String[] args) {
		String strPrice=JOptionPane.showInputDialog(null, Enter price of wine: "Price" ,JOptionPane.INFORMATION_MESSAGE);
		double price=Double.parseDouble(strPrice);
		String strNumBottles=JOptionPane.showInputDialog(null,"Enter no of Bottles","Inventory",JOptionPane.INFORMATION_MESSAGE);
		int numBottles= Integer.parseDouble(strNumBottles);
		double totalCost=price+numBottles;
		System.out.println("%-10s %5.2f\n" +"Total Cost:"+totalCost );
	}
}