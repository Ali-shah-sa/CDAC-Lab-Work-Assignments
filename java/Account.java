public class Account {
    private String accountType;
    private String accountNumber;
    private double minimumBalance;
    private double balance;

    public Account(String accountType, String accountNumber, double minimumBalance, double balance) {
        this.accountType = accountType;
        this.accountNumber = accountNumber;
        this.minimumBalance = minimumBalance;
        this.balance = balance;
    }

    public String getAccountType() {
        return accountType;
    }

    public String getAccountNumber() {
        return accountNumber;
    }

    public double getMinimumBalance() {
        return minimumBalance;
    }

    public double getBalance() {
        return balance;
    }

    public double calculateInterest(double rate, double time) {
        // Simple Interest Formula: Interest = (Principal * Rate * Time) / 100
        return (balance * rate * time) / 100;
    }

    public void disp() {
        System.out.println("Account Details:");
        System.out.println("Account Type: " + accountType);
        System.out.println("Account Number: " + accountNumber);
        System.out.println("Minimum Balance: " + minimumBalance);
        System.out.println("Current Balance: " + balance);
    }

    public static void main(String[] args) {
        Account account1 = new Account("Savings", "123456789", 5000.00, 20000.00);
        account1.disp();

        double interest = account1.calculateInterest(5, 2);
        System.out.println("\nCalculated Interest: " + interest);
    }
}
