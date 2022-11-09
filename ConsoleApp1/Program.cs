using ConsoleApp1;
using System.Text;
using static ConsoleApp1.Transport;

Console.WriteLine("Выберите нужный пункт меню: \n 1-Внести легковое авто\n 2-Внести грузовое авто\n 3-Внести мотоцикл\n 4-Вывести список легковых авто\n 5-Вывести список грузовых авто\n 6-Вывести список мотоциклов\n 7-Выход\n");
    string punkt = Console.ReadLine();

    LightCar car1 = new LightCar();
    Truck car2 = new Truck();
    Bike car3 = new Bike();
    Person per1 = new Person();
    Person per2 = new Person();
    Person per3 = new Person();
    Parking park1 = new Parking();
    Parking park2 = new Parking();
    Parking park3 = new Parking();

    if (punkt == "1") { car1.PrintLC();  per1.PrintP1(); park1.PrintPark1(); return; }
    else if (punkt == "2") { car2.PrintTruck(); per2.PrintP2(); park2.PrintPark2(); return; }
    else if (punkt == "3") { car3.PrintBike(); per3.PrintP3(); park3.PrintPark3(); return ; }
    else if (punkt == "4") { ShowLC(); return; }
    else if (punkt == "5") { ShowT(); return; }
else if (punkt == "6") { ShowT(); return; }
else if (punkt == "7") { Environment.Exit(0); }
    else { Console.WriteLine("Выбран неверный пункт меню."); }

 async Task ShowLC()
{
    string path = @"C:\\Users\\vsoko\\source\\repos\\ConsoleApp1\\ConsoleApp1\\LightCars.txt";
    using (FileStream fstream = File.OpenRead(path))
    {
        
        byte[] buffer = new byte[fstream.Length];
        
        await fstream.ReadAsync(buffer, 0, buffer.Length);
       
        string textFromFile = Encoding.Default.GetString(buffer);
        Console.WriteLine($"Список легковых авто:\n {textFromFile}");
        fstream.Close();
    }
    string path1 = @"C:\\Users\\vsoko\\source\\repos\\ConsoleApp1\\ConsoleApp1\\LCPerson.txt";
    using (FileStream fstream = File.OpenRead(path1))
    {

        byte[] buffer = new byte[fstream.Length];

        await fstream.ReadAsync(buffer, 0, buffer.Length);

        string textFromFile = Encoding.Default.GetString(buffer);
        Console.WriteLine($"Список владельцев:\n {textFromFile}");
        fstream.Close();
    }
    string path2 = @"C:\\Users\\vsoko\\source\\repos\\ConsoleApp1\\ConsoleApp1\\LCParking.txt";
    using (FileStream fstream = File.OpenRead(path2))
    {

        byte[] buffer = new byte[fstream.Length];

        await fstream.ReadAsync(buffer, 0, buffer.Length);

        string textFromFile = Encoding.Default.GetString(buffer);
        Console.WriteLine($"Информация о парковке:\n {textFromFile}");
        fstream.Close();
    }
}

 async Task ShowT()
 {  
    string path = @"C:\\Users\\vsoko\\source\\repos\\ConsoleApp1\\ConsoleApp1\\Trucks.txt";
    using (FileStream fstream = File.OpenRead(path))
    {

        byte[] buffer = new byte[fstream.Length];

        await fstream.ReadAsync(buffer, 0, buffer.Length);

        string textFromFile = Encoding.Default.GetString(buffer);
        Console.WriteLine($"Список грузовых авто:\n {textFromFile}");
        fstream.Close();
    }
    string path1 = @"C:\\Users\\vsoko\\source\\repos\\ConsoleApp1\\ConsoleApp1\\TPerson.txt";
    using (FileStream fstream = File.OpenRead(path1))
    {

        byte[] buffer = new byte[fstream.Length];

        await fstream.ReadAsync(buffer, 0, buffer.Length);

        string textFromFile = Encoding.Default.GetString(buffer);
        Console.WriteLine($"Список владельцев:\n {textFromFile}");
        fstream.Close();
    }
    string path2 = @"C:\\Users\\vsoko\\source\\repos\\ConsoleApp1\\ConsoleApp1\\TParking.txt";
    using (FileStream fstream = File.OpenRead(path1))
    {

        byte[] buffer = new byte[fstream.Length];

        await fstream.ReadAsync(buffer, 0, buffer.Length);

        string textFromFile = Encoding.Default.GetString(buffer);
        Console.WriteLine($"Информация о парковке:\n {textFromFile}");
        fstream.Close();
    }
}

async Task ShowB()
{
    string path = @"C:\\Users\\vsoko\\source\\repos\\ConsoleApp1\\ConsoleApp1\\Bikes.txt";
    using (FileStream fstream = File.OpenRead(path))
    {

        byte[] buffer = new byte[fstream.Length];

        await fstream.ReadAsync(buffer, 0, buffer.Length);

        string textFromFile = Encoding.Default.GetString(buffer);
        Console.WriteLine($"Список мотоциклов:\n {textFromFile}");
        fstream.Close();
    }
    string path1 = @"C:\\Users\\vsoko\\source\\repos\\ConsoleApp1\\ConsoleApp1\\BPerson.txt";
    using (FileStream fstream = File.OpenRead(path1))
    {

        byte[] buffer = new byte[fstream.Length];

        await fstream.ReadAsync(buffer, 0, buffer.Length);

        string textFromFile = Encoding.Default.GetString(buffer);
        Console.WriteLine($"Список владельцев:\n {textFromFile}");
        fstream.Close();
    }
    string path2 = @"C:\\Users\\vsoko\\source\\repos\\ConsoleApp1\\ConsoleApp1\\BParking.txt";
    using (FileStream fstream = File.OpenRead(path1))
    {

        byte[] buffer = new byte[fstream.Length];

        await fstream.ReadAsync(buffer, 0, buffer.Length);

        string textFromFile = Encoding.Default.GetString(buffer);
        Console.WriteLine($"Информация о парковке:\n {textFromFile}");
        fstream.Close();
    }
}