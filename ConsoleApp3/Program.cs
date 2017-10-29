using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            var cats = new List<CatClass>
            {
                new Tiger(),
                new Puma(),
                new Lion(),
                new Cat()

            };

            foreach (var mycat in cats)
            {
                mycat.Roar();
                Console.WriteLine($"размер этого кота - {mycat.Size}");

                if (mycat is IDangerous)
                {
                    var catDangerously = mycat as IDangerous;
                    catDangerously.Danger();
                }

            }
        }
    }
}
