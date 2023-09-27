using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Journal
    {
        public string name;
        public int year;
        public string comment;
        public string phone;
        public string email;
        public int count;
        public Journal() { }
        public Journal(string name, int year, string comment, string phone, string email, int count)
        {
            this.name = name;
            this.year = year;
            this.comment = comment;
            this.phone = phone;
            this.email = email;
            this.count = count;
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value == " " || value.Length == 0)
                {
                    throw new Exception("Ошибка: Пустая строка, или пробел!");
                }
                name = value;
            }
        }
        public int Year { get { return year; } set { year = value; } }
        public string Comment
        {
            get { return comment; }
            set
            {
                if (value == " " || value.Length == 0)
                {
                    throw new Exception("Ошибка: Пустая строка, или пробел!");
                }
                comment = value;
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                if (value == " " || value.Length == 0)
                {
                    throw new Exception("Ошибка: Пустая строка, или пробел!");
                }
                phone = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (value == " " || value.Length == 0)
                {
                    throw new Exception("Ошибка: Пустая строка, или пробел!");
                }
                email = value;
            }
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public override string ToString()
        {
            return $"\nНазвание журнала: {name}\tГод выпуска: {year}\t" +
                $"Описание журнала: {comment}\tКонтактный телефон: {phone}\tКонтактный e-mail: {email}\tКолличество сотрудников: {count}\n";
        }
        public void Input()
        {
            Console.WriteLine("Введите название журнала: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите год выпуска журнала: ");
            Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите описание журнала: ");
            Comment = Console.ReadLine();
            Console.WriteLine("Введите контактный телефон журнала: ");
            Phone = Console.ReadLine();
            Console.WriteLine("Введите контактный e-mail журнала: ");
            Email = Console.ReadLine();
            Console.WriteLine("Введите колличество сотрудников журнала: ");
            Count = Convert.ToInt32(Console.ReadLine());
        }


        //перегрузка + (для увеличения количества сотрудников на указанную величину)
        public static Journal operator +(Journal obj, int a)
        {
            obj.count += a;
            return obj;
        }

        //перегрузка - (для уменьшения количества сотрудников на указанную величину)
        public static Journal operator -(Journal obj, int a)
        {
            if (obj.count < a)
            {
                throw new Exception("Ошибка!!! Кол-во сотрудников < указанное число");
            }
            obj.count -= a;
            return obj;
        }

        //перегрузка ++
        public static Journal operator ++(Journal obj)
        {
            obj.count++;
            return obj;
        }

        //перегрузка == (проверка на равенство количества сотрудников)
        public static bool operator ==(Journal a, Journal b)
        {
            return a.count == b.count;
        }
        public static bool operator !=(Journal a, Journal b)
        {
            return a.count != b.count;
        }

        //перегрузка < и > (проверка на меньше или больше количества сотрудников)
        public static bool operator <(Journal a, Journal b)
        {
            return a.count < b.count;
        }
        public static bool operator >(Journal a, Journal b)
        {
            return a.count > b.count;
        }

        //перегрузка Equals
        public override bool Equals(object obj)
        {
            if (obj is Journal)
            {
                Journal j = obj as Journal;
                if (this.name == j.name && this.year == j.year && this.comment == j.comment
                    && this.phone == j.phone && this.email == j.email && this.count == j.count)
                    return true;
                else
                    return false;
            }
            throw new Exception("Тип != Journal");
        }
    }
}
