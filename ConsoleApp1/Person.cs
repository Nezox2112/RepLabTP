using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        public string fname;
        public string sname;
        public string age;

        public async Task PrintP1()
        {
            string path = "LCPerson.txt";
            await WritePerson(path);

        }
        public async Task PrintP2()
        {
            string path = "Person.txt";
            await WritePerson(path);

        }
        public async Task PrintP3()
        {
            string path = "BPerson.txt";
            await WritePerson(path);

        }


        private async Task WritePerson(string path)
        {
            Console.WriteLine("Введите имя: ");
            fname = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            sname = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            age = Console.ReadLine();
            Console.WriteLine($"Имя: {fname}; Фамилия: {sname}; Возраст: {age}");
            using (FileStream fstream = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                byte[] bufferf = Encoding.Default.GetBytes(Environment.NewLine + fname + " ");
                byte[] buffers = Encoding.Default.GetBytes(sname + " ");
                byte[] bufferage = Encoding.Default.GetBytes(age + " ");
                await fstream.WriteAsync(bufferf, 0, bufferf.Length);
                await fstream.WriteAsync(buffers, 0, buffers.Length);
                await fstream.WriteAsync(bufferage, 0, bufferage.Length);
                fstream.Close();
            }
        }
    }
}



