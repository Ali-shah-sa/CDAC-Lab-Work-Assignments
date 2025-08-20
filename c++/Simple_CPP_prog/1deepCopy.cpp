// Assignment: 

// 1. In String class, implement following:
//    - Copy constructor to perform deep copy.
//    - Overload assignment operator, to perform deep copy.

#include <iostream>
#include <cstring>
using namespace std;

class String {
private:
    char* str;

public:
    String() : str(nullptr) {}

    String(const char* s) {
        if (s) {
            str = new char[strlen(s) + 1];
            strcpy(str, s);
        } else {
            str = nullptr;
        }
    }

    String(const String& other) {
        if (other.str) {
            str = new char[strlen(other.str) + 1];
            strcpy(str, other.str);
        } else {
            str = nullptr;
        }
    }

    String& operator=(const String& other) {
        if (this == &other) {
            return *this; 
        }
        delete[] str; 

        if (other.str) {
            str = new char[strlen(other.str) + 1];
            strcpy(str, other.str);
        } else {
            str = nullptr;
        }

        return *this;
    }

    ~String() {
        delete[] str;
    }

    void display() const {
        if (str) {
            cout << str;
        } else {
            cout << "Empty";
        }
    }
};

int main() {
    String s1("Dell");
    String s2;
    String s3 = s1;
    s2 = s1;

    cout << "s1: ";
    s1.display();
    cout << endl;

    cout << "s2: ";
    s2.display();
    cout << endl;

    cout << "s3: ";
    s3.display();
    cout << endl;
    s2 = "string is changed";

    cout << "After changin:" << std::endl;
    cout << "s1: ";
    s1.display();
    cout << endl;
    cout << "s2: ";
    s2.display();
    cout << endl;
    cout << "s3: ";
    s3.display();
    cout << endl;
    return 0;
}
