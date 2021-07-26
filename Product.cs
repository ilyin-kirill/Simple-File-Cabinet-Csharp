using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilyin_oopp5
{
    [Serializable]
    class Product
    {
        private string name;
        private int weight;
        private string producer;
        public virtual void ReadConsole()
        {
            Console.WriteLine("Enter the name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the weight");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the producer: ");
            producer = Console.ReadLine();

        }
        public virtual void WriteConsole()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Weight(gr): " + weight);
            Console.WriteLine("Producer: " + producer);
        }
    }
}
