using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Zadanie5
{
    class Student
    {
        public int ID;
        public string FIO;
        public string Group;
        public string Data;

        ArrayList student = new ArrayList();
        ArrayList students = new ArrayList();
        public void dobavit()
        {
            Console.WriteLine("Введите данные студента");
            Random r = new Random();
            ID = r.Next(20);
            Console.WriteLine("Введите ФИО");
            FIO = Console.ReadLine();
            Console.WriteLine("Введите Группу");
            Group = Console.ReadLine();
            Console.WriteLine("Введите Дату");
            Data = Console.ReadLine();
            student = new ArrayList();
            student.Add(ID);
            student.Add(FIO);
            student.Add(Group);
            student.Add(Data);
            string s = "Номер студента: " + student[0] + "\nФИО: " + student[1] + "\nГруппа: " + student[2] + "\nДата: " + student[3];
            students.Add(s);
        }

        public void izmenit()
        {
            int n = students.Count - 1;
            Console.WriteLine("Вебирете индекс студента (от 0 до " + n + " ), которого надо изменить");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите, что нужно изменить: \n1 - ФИО\n2 - Группу\n3 - Дату рождения");
            int v = Convert.ToInt32(Console.ReadLine());
            if(v == 1)
            {
                Console.WriteLine("Введите ФИО");
                string fio = Console.ReadLine();
                student[1] = fio;
            }
            if (v == 2)
            {
                Console.WriteLine("Введите Группу");
                string group = Console.ReadLine();
                student[2] = group;
            }
            if (v == 3)
            {
                Console.WriteLine("Введите Дату");
                string data = Console.ReadLine();
                student[3] = data;
            }
            int t = n;

            string st = "Номер студента: " + student[0] + "\nФИО: " + student[1] + "\nГруппа: " + student[2] + "\nДата: " + student[3];
            students[s] = st;
        }

        public void delite()
        {
            int n = students.Count - 1;
            Console.WriteLine("Вебирете индекс студента (от 0 до "+ n + " ), которого надо удалить");
            int s = Convert.ToInt32(Console.ReadLine());
            students.RemoveAt(s);
            
        } 
        public void inf()
        {
            for(int i = 0; i < students.Count; i++)
            {
                 Console.WriteLine(students[i] + "\n");
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.dobavit();Console.WriteLine();
            s.dobavit(); Console.WriteLine();
            s.inf(); Console.WriteLine();
            s.delite(); Console.WriteLine();
            s.inf(); Console.WriteLine();
            s.dobavit(); Console.WriteLine();
            s.inf(); Console.WriteLine();
            s.izmenit(); Console.WriteLine();
            s.inf();
        }
    }
}
