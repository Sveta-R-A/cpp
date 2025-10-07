#pragma once
#include "B.h"
#include<iostream>
using namespace std;
class D2 : public B {
protected:
    float d2;
public:
    D2() {
        cout << "Викликано конструктор без параметрів (D2)"<<endl;
        cout << "Введіть d2(float): ";
        cin >> d2;
    }
    void showD2() {
        B::showB();
        cout << "d2 = " << d2 << endl;
    }
    ~D2() { cout << "Викликано деструктор (D2)" << endl; }
};