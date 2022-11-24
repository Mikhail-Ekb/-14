using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Имя1";
            string name2 = "Имя2";
            Animal cat = new Cat(name1);
            cat.ShowInfo();
            Animal dog = new Dog(name2);
            dog.ShowInfo();
            Console.ReadKey();
        }
    }


    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }

    class Cat : Animal
    {
        string name;

        public Cat(string name)
            : base(name)
        {
        }

        public override string Name
        {
            get => name;
            set => name = value;
        }

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }

    class Dog : Animal
    {
        string name;

        public Dog(string name) : base(name)
        {
        }

        public override string Name
        {
            get => name;
            set => name = value;
        }

        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
