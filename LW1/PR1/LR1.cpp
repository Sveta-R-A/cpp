
#include <iostream>
#include<Windows.h>
#include<cctype>
#include "Header.h"
using namespace std;

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
   
    cout << "Демонстрація конструкторів" << endl;
    Address a;  
    Address b("Оля", "Шевченка",8);
    Address c = b; 

    
    a.setname("Іван");
    a.setstreet("Грушевського");
    a.setnumber_house(8);

    a.showAll();
   

    cout <<endl<< "Використання методів" << endl;
    b.showname();
    b.showstreet();
    b.shownumber_house();

    cout <<endl<< "Покажчик на об'єкт" << endl;
    Address* ptrObj = &b;
    ptrObj->showname();  

    cout <<endl<< "Покажчик на метод" << endl;
    void (Address:: * ptrMethod)();   
    ptrMethod = &Address::showstreet; 

    (b.*ptrMethod)();

}

