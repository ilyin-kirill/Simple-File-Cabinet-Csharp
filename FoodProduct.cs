using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilyin_oopp5
{
    [Serializable]
    class FoodProduct: Product
    {
        private string fresh;
        private int price;
        public override void ReadConsole()
        {
            base.ReadConsole();
            Console.WriteLine("Enter the fresh: ");
            fresh = Console.ReadLine();
            Console.WriteLine("Enter the price: ");
            price = Convert.ToInt32(Console.ReadLine());
        }
        public override void WriteConsole()
        {
            base.WriteConsole();
            Console.WriteLine("Fresh: " + fresh);
            Console.WriteLine("Price: " + price);
        }
    }
}
