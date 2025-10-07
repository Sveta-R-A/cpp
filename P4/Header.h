#pragma once
#include<iostream>
#include<Windows.h>
using namespace std;

class B1 {
protected:
    int b1;
public:
    B1() : b1(0) {
        cout << "Конструктор без параметрів (B1)" << endl;
        cout << "Введення даних з клавіатури\nВведіть B1 (int): ";
        cin >> b1;
    }
    void show() { cout << "B1: " << b1 << endl; }
    ~B1() { cout << "викликано деструктор (B1)" << endl; }
};

class B2 {
protected:
    float b2;
public:
    B2() : b2(0) {
        cout << "Конструктор без параметрів (B2)" << endl;
        cout << "Введення даних з клавіатури\nВведіть B2 (float): ";
        cin >> b2;
    }
    void show() { cout << "B2: " << b2 << endl; }
    ~B2() { cout << "викликано деструктор (B2)" << endl; }
};

class B3 {
protected:
    double b3;
public:
    B3() : b3(0) {
        cout << "Конструктор без параметрів (B3)" << endl;
        cout << "Введення даних з клавіатури\nВведіть B3 (double): ";
        cin >> b3;
    }
    void show() { cout << "B3: " << b3 << endl; }
    ~B3() { cout << "викликано деструктор (B3)" << endl; }
};

class D1 : public B1, public B2, private B3 {
protected:
    char d1;
public:
    D1() : d1(0) {
        cout << "Конструктор без параметрів (D1)" << endl;
        cout << "Введення даних з клавіатури\nВведіть D1 (char): ";
        cin >> d1;
    }
    void show() {
        cout << "D1: " << d1 << endl;
        B1::show();
        B2::show();
        B3::show();
    }
    void setB3(double val) { B3::b3 = val; } 
    ~D1() { cout << "викликано деструктор (D1)" << endl; }
};

class D2 : public D1 {
protected:
    string d2;
public:
    D2() : d2("") {
        cout << "Конструктор без параметрів (D2)" << endl;
        cout << "Введення даних з клавіатури\nВведіть D2 (string): ";
        cin >> d2;
    }
    void show() {
        cout << "D2: " << d2 << endl;
        D1::show();
    }
    ~D2() { cout << "викликано деструктор (D2)" << endl; }
};