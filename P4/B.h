#pragma once
#include<Windows.h>
#include<iostream>
using namespace std;

class B {
protected:
    int b;
public:
    B() {
        cout << "Викликано конструктор без параметрів (B)"<<endl;
        cout << "Введіть b(int): ";
        cin >> b;
    }
    void showB() {
        cout << "b = " << b << endl;
    }
    ~B() { cout << "Викликано деструктор (B)" << endl; }
};






