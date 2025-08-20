package com.example.access;

public class AccessTest 
{
    public static void main(String[] args) 
    {
        PublicClass publicClass = new PublicClass();
        publicClass.showPublicMessage();

        System.out.println("Attempt to access PackagePrivateClass resulted in compilation failure.");
    }
}

class PublicClass {
    public void showPublicMessage() {
        System.out.println("This is a public msg");
    }
}

class PackagePrivateClass 
{
    void showPackagePrivateMessage()
     {
        System.out.println("This is a package-private msg");
    }
}
