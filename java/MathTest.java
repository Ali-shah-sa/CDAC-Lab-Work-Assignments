
package com.example.math;

public class Calculator {
    public int add(int a, int b) {
        return a + b;
    }

    public int subtract(int a, int b) {
        return a - b;
    }
}



package com.example.test;
import com.example.math.Calculator;

public class MathTest {
    public static void main(String[] args) {
        Calculator calculator = new Calculator();

        int sum = calculator.add(12, 8);
        System.out.println("Sum: " + sum);

        int difference = calculator.subtract(20, 5);
        System.out.println("Difference: " + difference);
    }
}



//javac com/example/math/Calculator.java com/example/test/MathTest.java
//java com.example.test.MathTest
