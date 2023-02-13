using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Human
    {
        int age = 33;
        string name = "Человек";
        string desc = "Существует";
        public void Print()
        {
            Console.WriteLine("Имя: " + age);
            Console.WriteLine("Возраст: " + name);
            Console.WriteLine("Описание: " + desc);
        }
    }
    public class Builder : Human
    {
        public void Age(int age)
        {
            age = 34;
        }
        public void Name(string name)
        {
            name = "Строитель";
        }
        public void Desc(string desc)
        {
            desc = "Строит";
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Имя: " + age);
            Console.WriteLine("Возраст: " + name);
            Console.WriteLine("Описание: " + desc);
        }
    }
    public class Sailor : Human
    {
        public void Age(int age)
        {
            age = 35;
        }
        public void Name(string name)
        {
            name = "Моряк";
        }
        public void Desc(string desc)
        {
            desc = "Морячит";
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Имя: " + age);
            Console.WriteLine("Возраст: " + name);
            Console.WriteLine("Описание: " + desc);
        }
    }
    public class Pilot : Human
    {
        public void Age(int age)
        {
            age = 36;
        }
        public void Name(string name)
        {
            name = "Летчик";
        }
        public void Desc(string desc)
        {
            desc = "Летает";
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Имя: " + age);
            Console.WriteLine("Возраст: " + name);
            Console.WriteLine("Описание: " + desc);
        }
    }


    public class Passport
    {
        string name = "";
        string number="";
        string date = "";
        string city = "";
        public void Name(string name)
        {
            name = "Имя";
        }
        public void Number(string number)
        {
            number = "0000000000";
        }
        public void Date(string date)
        {
            date = "01.01.2003";
        }
        public void City(string city)
        {
            city = "Одесса";
        }
        public void Print()
        {
            Console.WriteLine("Имя:" + name);
            Console.WriteLine("Номер пасспорта:" + number);
            Console.WriteLine("Дата рождения:" + date);
            Console.WriteLine("Город:" + city);
        }
    }
    public class ForeignPassport : Passport
    {
        public void NumberF(string number)
        {
            number = "000000000000";
        }
        public void Visas(string visas)
        {
            visas = "Нету";
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Номер заграничного паспорта: " + number);
            Console.WriteLine("Данные о визах: " + visas);
        }
            

    }

    public class Animal
    {
        string name = "";
        string speed = "";
        string hp = "";
        public void Print()
        {
            Console.WriteLine("Животное:");
        }
    }
    public class Tiger : Animal
    {
        public void Name(string name)
        {
            name = "Тигр";
        }
        public void Speed(string speed)
        {
            speed = "30";
        }
        public void Hp(string hp)
        {
            hp = "150";
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Имя:"+ name);
            Console.WriteLine("Скорость:"+ speed);
            Console.WriteLine("ХП:"+ hp);
        }
    }
    public class Crocodile : Animal
    {
        public void Name(string name)
        {
            name = "Крокодил";
        }
        public void Speed(string speed)
        {
            speed = "10";
        }
        public void Hp(string hp)
        {
            hp = "300";
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Имя:" + name);
            Console.WriteLine("Скорость:" + speed);
            Console.WriteLine("ХП:" + hp);
        }
    }
    public class Kangaroo : Animal
    {
        public void Name(string name)
        {
            name = "Кенгуру";
        }
        public void Speed(string speed)
        {
            speed = "20";
        }
        public void Hp(string hp)
        {
            hp = "175";
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Имя:" + name);
            Console.WriteLine("Скорость:" + speed);
            Console.WriteLine("ХП:" + hp);
        }
    }



}
