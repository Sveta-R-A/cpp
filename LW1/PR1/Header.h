#pragma once
#include<iostream>
#include<cctype>
using namespace std;
class Address {
private:
    string name, street;
    int number_house = 0;
public:
    Address()
    {
        cout << "викликано конструктор без параметрів" << endl;
    }
    Address(string Name, string Street, int Number_house)
    {
        name = Name;
        street = Street;
        number_house = Number_house;
        cout << "Викликано конструктор з параметром" << endl;
    }
    Address(const Address& other)
    {
        name = other.name;
        street = other.street;
        number_house = other.number_house;
        cout << "Викликано конструктор копіювання" << endl;
    }
    ~Address()
    {
        cout << "викликано диструктор" << endl;
    }

    void setname(string Name) { name = Name; }
    string getname() { return name; }

    void setstreet(string Street) { street = Street; }
    string getstreet() { return street; }

    void setnumber_house(int Number_house)
    {
        if (Number_house < 0)cout << endl << "Номер будинку не може бути менше 0" << endl;
        else if (isalpha(Number_house))cout << endl << "Не можна вводити букву" << endl;
        else
            number_house = Number_house;
    }
    int getnumber_house() { return number_house; }

    void showname() { cout << "Ім'я: " << name << endl; }
    void showstreet() { cout << "Вулиця: " << street << endl; }
    void shownumber_house() { cout << "Номер будинку: " << number_house << endl; }

    void showAll()
    {
        cout << "Ім'я: " << name << endl;
        cout << "Вулиця: " << street << endl;
        cout << "Номер будинку: " << number_house << endl;
    }

};