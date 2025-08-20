package com.company;

public class CompanyTest {
    public static void main(String[] args) {
        Account account = new Account();
        account.displayAccountDetails();

        Employee employee = new Employee();
        employee.displayEmployeeDetails();
    }
}

class Account {
    public void displayAccountDetails() {
        System.out.println("Displaying account details...");
    }
}

class Employee {
    public void displayEmployeeDetails() {
        System.out.println("Displaying employee details...");
    }
}




//com/company/CompanyTest.java
//javac com/company/CompanyTest.java
//java com.company.CompanyTest
//javac CompanyTest.java
//java CompanyTest
