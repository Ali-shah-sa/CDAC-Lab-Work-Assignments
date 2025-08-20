package com.example.utils;

public class MathUtils {
    public static double getPI() {
        return 3.14159; 
    }
}
package com.example.shapes;

import com.example.utils.MathUtils;

public class Circle {
    private double radius;

    public Circle(double radius) {
        this.radius = radius;
    }

    public double calculateArea() {
        return MathUtils.getPI() * radius * radius;
    }
}
package com.example.test;

import com.example.shapes.Circle;

public class ShapeTest {
    public static void main(String[] args) {
        Circle circle = new Circle(5.0); 
        double area = circle.calculateArea();
        System.out.println("Area of the circle: " + area);
    }
}


//javac com/example/**/*.java
//java com.example.test.ShapeTest
