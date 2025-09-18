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
        cout << "��������� ����������� ��� ���������" << endl;
    }
    Address(string Name, string Street, int Number_house)
    {
        name = Name;
        street = Street;
        number_house = Number_house;
        cout << "��������� ����������� � ����������" << endl;
    }
    Address(const Address& other)
    {
        name = other.name;
        street = other.street;
        number_house = other.number_house;
        cout << "��������� ����������� ���������" << endl;
    }
    ~Address()
    {
        cout << "��������� ����������" << endl;
    }

    void setname(string Name) { name = Name; }
    string getname() { return name; }

    void setstreet(string Street) { street = Street; }
    string getstreet() { return street; }

    void setnumber_house(int Number_house)
    {
        if (Number_house < 0)cout << endl << "����� ������� �� ���� ���� ����� 0" << endl;
        else if (isalpha(Number_house))cout << endl << "�� ����� ������� �����" << endl;
        else
            number_house = Number_house;
    }
    int getnumber_house() { return number_house; }

    void showname() { cout << "��'�: " << name << endl; }
    void showstreet() { cout << "������: " << street << endl; }
    void shownumber_house() { cout << "����� �������: " << number_house << endl; }

    void showAll()
    {
        cout << "��'�: " << name << endl;
        cout << "������: " << street << endl;
        cout << "����� �������: " << number_house << endl;
    }

};