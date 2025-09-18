/*7.АДРЕСА
ім'я- char*
вулиця- char*
номер будинку- int
*/

using System.Net;

class Address
{
    private string name, street;
    private int number_house=0;
    public string Name
    {
        get => name;
        set => name = value;
    }

    public string Street
    {
        get => street;
        set => street = value;
    }

    public int NumberHouse
    {
        get => number_house;
        set => SetNumberHouse(value);
    }
    private void SetNumberHouse(int value)
    {
        if (value < 0)
        {
            Console.WriteLine("Номер будинку не може бути менше 0");
        }
        else
        {
            number_house = value;
        }
    }

    public Address()
    {
        Console.WriteLine("Викликано конструктор без параметрів");
    }
    public Address(string Name,string Street,int Number_house)
    {
        name = Name;
        this.street = Street;
        this.number_house = Number_house;
        Console.WriteLine("Викликано конструктор з параметром");
    }
    public Address( Address other)
    {
        name = other.name;
        street = other.street;
        number_house = other.number_house;
        Console.WriteLine("Викликано конструктор копіювання");
    }

    ~Address()
    {
        Console.WriteLine("Викликано деструктор");
    }
    public void ShowAll()
    {
        Console.WriteLine($"Ім'я: {name}");
        Console.WriteLine($"Вулиця: {street}");
        Console.WriteLine($"Номер будинку: {number_house}");
    }
    public void ShowName()
    {
        Console.WriteLine($"Ім'я: {Name}");
    }
    public void ShowStreet()
    {
        Console.WriteLine($"Вулиця: {Street}");
    }

}
class Program
{
    delegate void ShowMethod();
    static void Main(string[] args)
    {
        Console.WriteLine("Демонстрація конструкторів");
        Address a = new Address();
        Address b = new Address("Оля", "Шевченка", 8);
        Address c = new Address(b);

        a.Name = "Іван";
        a.Street = "Грушевського";
        a.NumberHouse = 8;

        a.ShowAll();

        Console.WriteLine("Використання методів");
        b.ShowAll();

        Console.WriteLine("Покажчик на об'єкт");
        Address ptrObj = b;
        ptrObj.ShowName();
        Console.WriteLine("Покажчик на метод");
        ShowMethod ptrMethod = b.ShowStreet;
        ptrMethod();
      
    }
}