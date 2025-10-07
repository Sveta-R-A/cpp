
#include <iostream>
#include<Windows.h>
#include "B.h"
#include "D2.h"
#include "D3_D1.h"
#include "D4.h"
#include "D1.h"
using namespace std;
int main()
{
    
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
   
    cout << "=== Об'єкт D4 ===\n";
    D4 obj4;
    obj4.showD4();

    cout << "\n\n=== Об'єкт D3 ===\n";
    D3 obj3;
    obj3.showD3();


}

