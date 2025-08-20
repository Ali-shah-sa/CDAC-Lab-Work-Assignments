
class StaticVarBank {
    private int accno;
    private String accType;
    private double balance;
    private static double interestRate;

    static {
        interestRate = 4.5; // Initialize the static variable
    }

    public StaticVarBank(int accno, String accType, double balance) {
        this.accno = accno;
        this.accType = accType;
        this.balance = balance;
    }

    public void deposit(double amount) {
        balance += amount;
        System.out.println("Deposited: " + amount + ", New Balance: " + balance);
    }

    public void withdraw(double amount) {
        if (balance >= amount) {
            balance -= amount;
            System.out.println("Withdrawn: " + amount + ", New Balance: " + balance);
        } else {
            System.out.println("Insufficient Balance!");
        }
    }

    public void displayAccountDetails() {
        System.out.println("Account Number: " + accno);
        System.out.println("Account Type: " + accType);
        System.out.println("Balance: " + balance);
        System.out.println("Interest Rate: " + interestRate);
    }

    public static void main(String[] args) {
        StaticVarBank account1 = new StaticVarBank(1001, "Savings", 5000);
        StaticVarBank account2 = new StaticVarBank(1002, "Current", 10000);

        System.out.println("Account 1 Details:");
        account1.displayAccountDetails();
        account1.deposit(1500);
        account1.withdraw(2000);

        System.out.println("\nAccount 2 Details:");
        account2.displayAccountDetails();
        account2.deposit(3000);
        account2.withdraw(12000);
    }
}
