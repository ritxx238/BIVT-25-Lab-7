using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet pet1 = new Pet("Чича", 3, 5);
            Cat cat1 = new Cat("Маня", 1, 3, "кухня");

            Pet hidenCat = new Cat("Рулет", 4, 4, "помойка");

            hidenCat.Simple();
            hidenCat.Print();

            //pet1.Simple();
            //pet1.Print();

            //cat1.Simple();
            //cat1.Print();

            Pet[] jp = new Pet[] { pet1, cat1, hidenCat };
            for(int i = 0; i < jp.Length; i++)
            {
                if (jp[i] is Cat)
                {
                    Cat s = jp[i] as Cat;
                    Console.WriteLine(s.Room);
                }
            }
        }

    }
    public class Pet //домашнее животное
    {
        protected string _name;
        protected int _age;
        protected int _fur;


        public Pet(string name, int age, int fur)
        {
            _name = name;
            _age = age;
            _fur = fur;
        }
        public void Simple()
        {
            Console.WriteLine("Вызов животного");
        }
        public virtual void Print()
        {
            Console.WriteLine($"Pet: {_name}, возраст: {_age}, шерсть: {_fur}.");
        }
    }
    public class Cat : Pet
    {
        private string _room;
        public string Room => _room;
        public Cat(string name, int age, int fur, string room): base(name, age, fur) 
        {
            _room = room;
        }
        public void Simple()
        {
            Console.WriteLine("Вызов кошки");
        }
        public override void Print()
        {
            Console.WriteLine($"Pet: {_name}, возраст: {_age}, шерсть: {_fur}, комната: {_room}.");
        }
    }
}

