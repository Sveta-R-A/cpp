#pragma once
#include "D1.h";
#include<iostream>
using namespace std;
class D3 : protected D1 {
protected:
    char d3;
public:
    D3() {
        cout << "��������� ����������� ��� ��������� (D3)"<<endl;
        cout << "������ d3(char): ";
        cin >> d3;
    }
    void showD3() {
        cout << "\n--- ��� � D1 ---\n";
        D1::showD1();
        cout << "\n--- ��� � D3 ---\n";
        cout << "d3 = " << d3 << endl;
    }
    ~D3() { cout << "��������� ���������� (D3)" << endl; }
};