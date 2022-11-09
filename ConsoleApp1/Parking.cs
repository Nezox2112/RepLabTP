using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Parking
    {
        string day;
        string month;
        string year;
        string price;
        string discount;
        string debt;

        public async Task PrintPark1()
        {
            string path = "LCParking.txt";
            await PrintParkingInfo(path);
        }
        public async Task PrintPark2()
        {
            string path = "TParking.txt";
            await PrintParkingInfo(path);

        }
        public async Task PrintPark3()
        {
            string path = "BParking.txt";
            await PrintParkingInfo(path);

        }

        private async Task PrintParkingInfo(string path)
        {
            Console.WriteLine("Введите день: ");
            day = Console.ReadLine();
            Console.WriteLine("Введите месяц: ");
            month = Console.ReadLine();
            Console.WriteLine("Введите год: ");
            year = Console.ReadLine();
            Console.WriteLine("Введите цену(руб): ");
            price = Console.ReadLine();
            Console.WriteLine("Введите скидку(%): ");
            discount = Console.ReadLine();
            Console.WriteLine("Введите задолжность(руб): ");
            debt = Console.ReadLine();
            Console.WriteLine($"Дата въезда: {day} {month} {year}");
            Console.WriteLine($"Цена: {price} рублей; Скидка {discount}%; Задолжность: {debt} рублей");
            using (FileStream fstream = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                byte[] bufferd = Encoding.Default.GetBytes(Environment.NewLine + day + " ");
                byte[] bufferm = Encoding.Default.GetBytes(month + " ");
                byte[] buffery = Encoding.Default.GetBytes(year + " ");
                byte[] bufferp = Encoding.Default.GetBytes(price + " ");
                byte[] bufferdisc = Encoding.Default.GetBytes(discount + " ");
                byte[] bufferdebt = Encoding.Default.GetBytes(debt + " ");
                await fstream.WriteAsync(bufferd, 0, bufferd.Length);
                await fstream.WriteAsync(bufferm, 0, bufferm.Length);
                await fstream.WriteAsync(buffery, 0, buffery.Length);
                await fstream.WriteAsync(bufferp, 0, bufferp.Length);
                await fstream.WriteAsync(bufferdisc, 0, bufferdisc.Length);
                await fstream.WriteAsync(bufferdebt, 0, bufferdebt.Length);
                fstream.Close();

            }
        }


    }
}
