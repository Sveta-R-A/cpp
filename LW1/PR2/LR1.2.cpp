
#include <iostream>
#include<Windows.h>
using namespace std;
class Array
{
private:
	double** doubleArray;
	int n, m;
public:
	Array(int rows,int cols)
	{
		n = rows;
		m = cols;
		doubleArray = new double* [n];
		for (int j = 0; j < m; j++)
		{
			doubleArray[j] = new double [m];

		}
	}
	~Array()
	{
		for (int i = 0; i < n; i++) {
			delete[] doubleArray[i];
		}
		delete[] doubleArray;
	}

	void input()
	{
		srand(time(0));
		for(int i=0;i<n;i++)
			for (int j = 0; j < m; j++)
			{
				//cout << "Введіть елемент[" << i << "] [" << j << "]:" << endl;
				//cin >> doubleArray[i][j];
				doubleArray[i][j] = rand() % 201 - 100;
		    }
	}

	void output()
	{
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++)
			{
				cout << doubleArray[i][j] << "\t";
			}
			cout << endl;
		}
	}
	int countNull()
	{
		int count = 0;
		for (int i = 0; i < n; i++)
			for (int j = 0; j < m; j++)
			{
				if (doubleArray[i][j] == 0)count += 1;
			}
		return count;
	}
	int count()
	{
		return n * m;
	}

	void plusScalar(double scalar)
	{
		for (int i = 0; i < n; i++)
			for (int j = 0; j < m; j++)
			{
				doubleArray[i][j] += scalar;
		    }
	}

	void sort()
	{
		for (int j = 0; j < m; j++) {
			for (int i = 0; i < n - 1; i++) {
				for (int k = 0; k < n - i - 1; k++) {
					if (doubleArray[k][j] < doubleArray[k + 1][j]) {  
						swap(doubleArray[k][j], doubleArray[k + 1][j]);
					}
				}
			}
		}
	}
};

int perevirka() {
	int number;
	while (!(cin >> number) || number <= 0) {
		cin.clear();              
		cin.ignore(1000, '\n');   
		cout << "Помилка! Введіть невід’ємне число: ";
	}
	return number;
}
int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int cols, rows;
	double scalar;
	cout << "Введіть к-сть рядків:";
	rows=perevirka();
	cout << "Введіть к-сть стовпців:"; 
	cols=perevirka();
    Array mas(rows,cols);

	mas.input();
	cout << endl;

	cout << "Виведення масиву:" << endl;
	mas.output();
	cout << endl;

	cout << "Сортування:" << endl;
	mas.sort();
	mas.output();
	cout << endl;

	cout << "Загальна к-сть елемментів:";
	cout<<mas.count()<<endl;
	cout << endl;

	cout << "Кількість нульових елементів: " << mas.countNull() << endl;

	cout << "Введіть скаляр:"; cin >> scalar;
	mas.plusScalar(scalar);
	mas.output();
}

