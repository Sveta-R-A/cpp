#pragma once
#include<iostream>
using namespace std;
#include "B.h"
class D1 : private B {
protected:
    int d1;
public:
    D1() {
        cout << "��������� ����������� ��� ��������� (D1)\n";
        cout << "������ d1(int): ";
        cin >> d1;
    }
    void showD1() {
        B::showB();
        cout << "d1 = " << d1 << endl;
    }
    ~D1() { cout << "��������� ���������� (D1)" << endl; }
};