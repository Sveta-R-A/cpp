#pragma once
#include<Windows.h>
#include<iostream>
using namespace std;

class B {
protected:
    int b;
public:
    B() {
        cout << "��������� ����������� ��� ��������� (B)"<<endl;
        cout << "������ b(int): ";
        cin >> b;
    }
    void showB() {
        cout << "b = " << b << endl;
    }
    ~B() { cout << "��������� ���������� (B)" << endl; }
};






