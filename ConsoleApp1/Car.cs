using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Transport;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Transport
    {

        public string mark;
        public string color;
        public void PrintC()
        {

            Console.WriteLine("Введите марку транспорта: ");
            mark = Console.ReadLine();
            Console.WriteLine("Введите цвет: ");
            color = Console.ReadLine();


        }
        internal class Car : Transport
        {
            string model;
            string carage;
            public async Task PrintCar()
            {
                PrintC();
                string path = "LightCars.txt";
                Console.WriteLine("Введите модель: ");
                model = Console.ReadLine();
                Console.WriteLine("Введите год производства ");
                carage = Console.ReadLine();
                Console.WriteLine($"Марка: {mark}; Модель: {model}; Цвет: {color}; Год производства: {carage}");
                using (FileStream fstream = new FileStream(path, FileMode.Append, FileAccess.Write))
                {
                    byte[] buffermark = Encoding.Default.GetBytes(Environment.NewLine + mark + " ");
                    byte[] buffermodel = Encoding.Default.GetBytes(model + " ");
                    byte[] buffercolor = Encoding.Default.GetBytes(color + " ");
                    byte[] buffercarage = Encoding.Default.GetBytes(carage + " ");
                    await fstream.WriteAsync(buffermark, 0, buffermark.Length);
                    await fstream.WriteAsync(buffermodel, 0, buffermodel.Length);
                    await fstream.WriteAsync(buffercolor, 0, buffercolor.Length);
                    await fstream.WriteAsync(buffercarage, 0, buffercarage.Length);
                    fstream.Close();

                }




            }
        }

        internal class Truck : Transport
        {
            string weight;
            public async Task PrintTruck()
            {
                PrintC();
                string path = "";
                Console.WriteLine("Введите вес грузовика: ");
                weight = Console.ReadLine();
                Console.WriteLine($"Марка: {mark}; Цвет: {color}; Вес: {weight}");
                using (FileStream fstream = new FileStream(path, FileMode.Append, FileAccess.Write))
                {
                    byte[] buffermark = Encoding.Default.GetBytes(Environment.NewLine + mark + " ");
                    byte[] buffercolor = Encoding.Default.GetBytes(color + " ");
                    byte[] bufferweight = Encoding.Default.GetBytes(weight + " ");
                    await fstream.WriteAsync(buffermark, 0, buffermark.Length);
                    await fstream.WriteAsync(buffercolor, 0, buffercolor.Length);
                    await fstream.WriteAsync(bufferweight, 0, bufferweight.Length);
                    fstream.Close();

                }

            }
        }
        internal class Bike : Transport
        {
            string power;
            public async Task PrintBike()
            {
                string path = "Bikes.txt";
                PrintC();
                Console.WriteLine("Введите мощность двигателя (л/с): ");
                power = Console.ReadLine();
                Console.WriteLine($"Марка: {mark}; Цвет: {color}; Мощность: {power}л/с");
                using (FileStream fstream = new FileStream(path, FileMode.Append, FileAccess.Write))
                {
                    byte[] buffermark = Encoding.Default.GetBytes(Environment.NewLine + mark + " ");
                    byte[] buffercolor = Encoding.Default.GetBytes(color + " ");
                    byte[] bufferpower = Encoding.Default.GetBytes(power + " ");
                    await fstream.WriteAsync(buffermark, 0, buffermark.Length);
                    await fstream.WriteAsync(buffercolor, 0, buffercolor.Length);
                    await fstream.WriteAsync(bufferpower, 0, bufferpower.Length);
                    fstream.Close();

                }

            }
        }
    }
}

