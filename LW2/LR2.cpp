#include <iostream>
#include <vector>
#include <stdexcept>
#include <cstdlib>
#include <ctime>
#include<Windows.h>
#include "Header.h"
using namespace std;

int main() {
    int n1, m1;
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    cout << "Введiть кiлькiсть рядкiв для A: ";
    cin >> n1;
    cout << "Введiть кiлькiсть стовпцiв для A: ";
    cin >> m1;

    MyArr A(n1, m1);
    A.FillArr();
    cout << "Матриця A:" << endl;
    A.Out();

    int n2, m2;
    cout << "Введiть кiлькiсть рядкiв для B: ";
    cin >> n2;
    cout << "Введiть кiлькiсть стовпцiв для B: ";
    cin >> m2;

    MyArr B(n2, m2);
    B.FillArr();
    cout << "Матриця B:" << endl;
    B.Out();

    ++A;
    cout << "A пiсля ++:" << endl;
    A.Out();

    --B;
    cout << "B пiсля --:" << endl;
    B.Out();

    if (A)
        cout << "Усi рядки A впорядкованi" << endl;
    else
        cout << "Є рядки у A не впорядкованi" << endl;

    try {
        MyArr C = A * B;
        cout << "C = A * B:" << endl;
        C.Out();
    }
    catch (const exception& ex) {
        cout << "Помилка при множеннi: " << ex.what() << endl;
    }

    vector<vector<double>> jagged = A.ToJagged();
    cout << "A як схiдчастий масив:" << endl;
    for (auto& row : jagged) {
        for (auto val : row)
            cout << val << "\t";
        cout << endl;
    }

    MyArr D = MyArr::FromJagged(jagged);
    cout << "D пiсля зворотного перетворення:" << endl;
    D.Out();
        

    return 0;
}

