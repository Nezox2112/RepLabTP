using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    interface CarWrite
    {
        void write();
        
    }
    interface CarAdd
    {
        CarWrite add();
    }
    class Car : CarWrite
    {
        public string mark;
        public string color;
        public string number;
        public void Writing()
        {
            string path = "LightCars.txt";
            Console.WriteLine("Введите марку транспорта: ");
            mark = Console.ReadLine();
            Console.WriteLine("Введите цвет: ");
            color = Console.ReadLine();
            Console.WriteLine("Введите номерной знак: ");
            number = Console.ReadLine();
            using (FileStream fstream = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                byte[] buffermark = Encoding.Default.GetBytes(Environment.NewLine + mark + " ");     
                byte[] buffercolor = Encoding.Default.GetBytes(color + " ");
                byte[] buffernumber = Encoding.Default.GetBytes(number + " ");
                fstream.WriteAsync(buffermark, 0, buffermark.Length);
                fstream.WriteAsync(buffercolor, 0, buffercolor.Length);
                fstream.WriteAsync(buffernumber, 0, buffernumber.Length);
                fstream.Close();

            }
            Console.WriteLine("Машина добавлена в базу");

        }
        public void write() => Writing();
    }
    class Truck : CarWrite
    {
        public string mark;
        public string color;
        public string number;
        public void Writing()
        {
            string path = "Trucks.txt";
            Console.WriteLine("Введите марку транспорта: ");
            mark = Console.ReadLine();
            Console.WriteLine("Введите цвет: ");
            color = Console.ReadLine();
            Console.WriteLine("Введите номерной знак: ");
            number = Console.ReadLine();
            using (FileStream fstream = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                byte[] buffermark = Encoding.Default.GetBytes(Environment.NewLine + mark + " ");
                byte[] buffercolor = Encoding.Default.GetBytes(color + " ");
                byte[] buffernumber = Encoding.Default.GetBytes(number + " ");
                fstream.WriteAsync(buffermark, 0, buffermark.Length);
                fstream.WriteAsync(buffercolor, 0, buffercolor.Length);
                fstream.WriteAsync(buffernumber, 0, buffernumber.Length);
                fstream.Close();

            }
            Console.WriteLine("Грузовик добавлен в базу");

        }
        public void write() => Writing();
    }

    class Bike : CarWrite
    {
        public string mark;
        public string color;
        public string number;
        public void Writing()
        {
            string path = "Bikes.txt";
            Console.WriteLine("Введите марку транспорта: ");
            mark = Console.ReadLine();
            Console.WriteLine("Введите цвет: ");
            color = Console.ReadLine();
            Console.WriteLine("Введите номерной знак: ");
            number = Console.ReadLine();
            using (FileStream fstream = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                byte[] buffermark = Encoding.Default.GetBytes(Environment.NewLine + mark + " ");
                byte[] buffercolor = Encoding.Default.GetBytes(color + " ");
                byte[] buffernumber = Encoding.Default.GetBytes(number + " ");
                fstream.WriteAsync(buffermark, 0, buffermark.Length);
                fstream.WriteAsync(buffercolor, 0, buffercolor.Length);
                fstream.WriteAsync(buffernumber, 0, buffernumber.Length);
                fstream.Close();

            }
            Console.WriteLine("Мотоцикл добавлена в базу");

        }
        public void write() => Writing();
    }
    
    class CarPark : CarAdd
    {
        public CarWrite add() => new Car();
    }
    class TruckPark : CarAdd
    {
        public CarWrite add() => new Truck();
    }
    class BikePark : CarAdd
    {
        public CarWrite add() => new Bike();
    }

}

