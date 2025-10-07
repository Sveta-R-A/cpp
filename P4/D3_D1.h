#pragma once
#include "D1.h";
#include<iostream>
using namespace std;
class D3 : protected D1 {
protected:
    char d3;
public:
    D3() {
        cout << "Викликано конструктор без параметрів (D3)"<<endl;
        cout << "Введіть d3(char): ";
        cin >> d3;
    }
    void showD3() {
        cout << "\n--- Дані з D1 ---\n";
        D1::showD1();
        cout << "\n--- Дані з D3 ---\n";
        cout << "d3 = " << d3 << endl;
    }
    ~D3() { cout << "Викликано деструктор (D3)" << endl; }
};