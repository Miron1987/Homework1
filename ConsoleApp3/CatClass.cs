using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface IDangerous
    {
        void Danger();
    }


    public abstract class CatClass
    {
       public int Size { get; protected set; }
       public string Color { get; protected set; }

        public abstract void Roar();


    }

    public class Tiger : CatClass, IDangerous
    {

        public Tiger()
        {
            Size = 10;
            Color = "полосатый";

        }

        public void Danger()
        {
            Console.WriteLine("Осторожно, ты его не видишь, но он видит тебя!!!");
        }

        public override void Roar()
        {
            Console.WriteLine("рычит, как тигр");
        }
    }

    public class Puma : CatClass, IDangerous
    {

        public Puma()
        {
            Size = 5;
            Color = "черная";

        }

        public void Danger()
        {
            Console.WriteLine("Осторожно, пумы тоже кусаются!!!");
        }

        public override void Roar()
        {
            Console.WriteLine("рычит, как пума");
        }
    }

    public class Lion : CatClass, IDangerous
    {

        public Lion()
        {
            Size = 12;
            Color = "желтый";

        }

        public void Danger()
        {
            Console.WriteLine("Осторожно, львиный ВАНШОТ!!!");
        }

        public override void Roar()
        {
            Console.WriteLine("рычит, как лев");
        }
    }

    public class Cat : CatClass
    {

        public Cat()
        {
            Size = 1;
            Color = "желтый";

        }

        public override void Roar()
        {
            Console.WriteLine("мяукает");
        }
    }
}
