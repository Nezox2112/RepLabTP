using ConsoleApp1;
using System.Text;
using static ConsoleApp1.Transport;

Console.WriteLine("Выберите нужный пункт меню: \n 1-Внести легковое авто\n 2-Внести грузовое авто\n 3-Внести мотоцикл\n 4-Вывести список легковых авто\n 5-Вывести список грузовых авто\n 6-Вывести список мотоциклов\n 7-Выход\n");
string point = Console.ReadLine();

Car car1 = new Car();
Truck car2 = new Truck();
Bike car3 = new Bike();
Person per1 = new Person();
Person per2 = new Person();
Person per3 = new Person();
Parking park1 = new Parking();
Parking park2 = new Parking();
Parking park3 = new Parking();

switch (point)
{
    case "1":
        car1.PrintCar(); per1.PrintP1(); park1.PrintPark1(); return;
    case "2":
        car2.PrintTruck(); per2.PrintP2(); park2.PrintPark2(); return;
    case "3":
        car3.PrintBike(); per3.PrintP3(); park3.PrintPark3(); return;
    case "4":
        ShowCar(); return;
    case "5":
        ShowT(); return;
    case "6":
        ShowT(); return;
    case "7":
        Environment.Exit(0); break;
    default:
        Console.WriteLine("Выбран неверный пункт меню."); break;
}

async Task ShowCar()
{
    string path = "LightCars.txt";
    await ShowCarList(path);
    string path1 = "LCPerson.txt";
    await ShowPersonList(path1);
    string path2 = "LCParking.txt";
    await ShowParkingInfo(path2);
}

async Task ShowT()
{
    string path = "Trucks.txt";
    await ShowCarList(path);
    string path1 = "TPerson.txt";
    await ShowPersonList(path1);
    string path2 = "TParking.txt";
    await ShowParkingInfo(path2);

}

async Task ShowB()
{
    string path = "Bikes.txt";
    await ShowCarList(path);
    string path1 = "BPerson.txt";
    await ShowPersonList(path1);
    string path2 = "BParking.txt";
    await ShowParkingInfo(path2);

}

static async Task ShowCarList(string path)
{
    using (FileStream fstream = File.OpenRead(path))
    {

        byte[] buffer = new byte[fstream.Length];

        await fstream.ReadAsync(buffer, 0, buffer.Length);

        string textFromFile = Encoding.Default.GetString(buffer);
        Console.WriteLine($"Список транспорта:\n {textFromFile}");
        fstream.Close();
    }
}

static async Task ShowPersonList(string path1)
{
    using (FileStream fstream = File.OpenRead(path1))
    {

        byte[] buffer = new byte[fstream.Length];

        await fstream.ReadAsync(buffer, 0, buffer.Length);

        string textFromFile = Encoding.Default.GetString(buffer);
        Console.WriteLine($"Список владельцев:\n {textFromFile}");
        fstream.Close();
    }
}

static async Task ShowParkingInfo(string path2)
{
    using (FileStream fstream = File.OpenRead(path2))
    {

        byte[] buffer = new byte[fstream.Length];

        await fstream.ReadAsync(buffer, 0, buffer.Length);

        string textFromFile = Encoding.Default.GetString(buffer);
        Console.WriteLine($"Информация о парковке:\n {textFromFile}");
        fstream.Close();
    }
}