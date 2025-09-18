/*7.	Створити клас для роботи з двовимірним масивом дійсних чисел. Розробити наступні елементи класу: 
o	Поля: 
	double [][] DoubelArray; 
	int n, m. 
o	Конструктор, що дозволяє створити масив розмірності nЧm. 
o	Методи, що дозволяють: 
	ввести елементи масиву з клавіатури; 
	вивести елементи масиву на екран; 
	відсортувати елементи кожного рядка масиву в порядку убування. 
o	Властивості: 
	повертаюча загальна кількість елементів в масиві (доступне тільки для читання); 
	які надають можливість  збільшити значення всіх елементів масиву на скаляр (доступне тільки для запису). 
*/
using System;

class Array
{
    private double[,] doubleArray;
    private int n, m;
    public Array(int rows,int cols)
    {
        n = rows;
        m=cols;
        doubleArray=new double[n,m];
        
    }
    public void input()
    {
        Random rand = new Random();
        for (int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                doubleArray[i, j] = rand.Next(-100,101);
            }
        }
    }
    public void output() 
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{doubleArray[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
    public int countNull()
    {
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (doubleArray[i, j] == 0) count += 1;
            }
           
        }
        return count;
    }
   public int count()
    {
        return n * m;
    }
    public void plusScalar(double scalar)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                doubleArray[i, j] += scalar;
            }
        }
    }
   public void sort()
   {
        for (int j = 0; j < m; j++)               
        {
            for (int i = 0; i < n - 1; i++)         
            {
                for (int k = 0; k < n - i - 1; k++)
                {
                    if (doubleArray[k, j] < doubleArray[k + 1, j])
                    {
                        double temp = doubleArray[k, j];
                        doubleArray[k, j] = doubleArray[k + 1, j];
                        doubleArray[k + 1, j] = temp;
                    }
                }
            }
        }
    }
    
}
class Program
{
    public static int perevirka()
    {
        int result=0;
        int input=0;
        input =int.Parse( Console.ReadLine());
        if (input > 0) result = input;
        else
            while (result <= 0)
                {
                    Console.Write("Введіть позитивне ціле число: ");
                    input = int.Parse(Console.ReadLine());

                    if (result <= 0)
                    {
                        Console.WriteLine("Помилка! Будь ласка, введіть позитивне ціле число.");
                    }
                }

        return result;
    }
    static void Main(string[] args)
    {
        int cols, rows;
        double scalar;
        Console.WriteLine("Введіть к-сть рядків:");
       
        rows = perevirka();
        Console.WriteLine("Введіть к-сть стовпців:");
     
        cols = perevirka();
       
        Array mas = new Array(rows, cols);
        mas.input();
        Console.WriteLine();

        Console.WriteLine("Виведення масиву");
        mas.output();
        Console.WriteLine();

        Console.WriteLine("Сортування:");
        mas.sort();
        mas.output();
        Console.WriteLine();
        Console.WriteLine("Загальна к-сть елемментів:");
        Console.WriteLine(mas.count());
        Console.WriteLine();

        Console.WriteLine($"Кількість нульових елементів: {mas.countNull()} ");
        Console.WriteLine("Введіть скаляр:");
        scalar=double.Parse(Console.ReadLine());
        mas.plusScalar(scalar);
        mas.output();
    }

}
