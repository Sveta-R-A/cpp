#pragma once
#include "D1.h";
#include "D2.h"
#include<iostream>
using namespace std;
class D4 : public D1, protected D2 {
protected:
    string d4;
public:
    D4() {
        cout << "Викликано конструктор без параметрів (D4)\n";
        cout << "Введіть d4(string): ";
        cin >> d4;
    }
    void showD4() {
        cout << "\n--- Дані з D1 ---\n";
        D1::showD1();
        cout << "\n--- Дані з D2 ---\n";
        D2::showD2();
        cout << "\n--- Дані з D4 ---\n";
        cout << "d4 = " << d4 << endl;
    }
    ~D4() { cout << "Викликано деструктор (D4)" << endl; }
};