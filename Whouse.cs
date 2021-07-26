using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilyin_oopp5
{
    [Serializable]
    class Whouse
    {
        private List<Product> wh = new List<Product>();
        public void add_product()
        {
            Product product = new Product();
            product.ReadConsole();
            wh.Add(product);
        }
        public void add_food_product()
        {
            FoodProduct product = new FoodProduct();
            product.ReadConsole();
            wh.Add(product);
        }
        public void view_list()
        {
            foreach(Product it in wh)
            {
                it.WriteConsole();
                Console.WriteLine();
            }
        }
        public void fout_list()
        {
            Console.WriteLine("\nEnter the filename:");
            string file = Console.ReadLine();
            using (FileStream fout = new FileStream(file, FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fout, wh);
            }
        }
        public void fin_list()
        {
            Console.WriteLine("\nEnter the filename:");
            string file = Console.ReadLine();
            using (FileStream fin = new FileStream(file, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                wh = formatter.Deserialize(fin) as List<Product>;
            }
        }
        public void clear_list()
        {
            wh.Clear();
        }
    }
}
