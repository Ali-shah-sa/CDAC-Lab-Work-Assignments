package com.example.access;
public class PublicClass 
{
    public void showPublicMessage() 
    {
        System.out.println("This is a public msg");
    }
}
class PackagePrivateClass
 {
    void showPackagePrivateMessage() 
    {
        System.out.println("This is a package-private msg");
    }

package com.example.test;

import com.example.access.PublicClass;

public class AccessTest
 {
    public static void main(String[] args) 
    {
        PublicClass publicClass = new PublicClass();
        publicClass.showPublicMessage();
        System.out.println("private methods and classes are not accessible outside the package.");
    }
}
