using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilyin_oopp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            Whouse products = new Whouse();
            do
            {
                Console.WriteLine("\n" +
            "1. Add the product into warehouse\n" +
            "2. Add the food product\n" +
            "3. View the list of products\n" +
            "4. Scan the file\n" +
            "5. Save in file\n" +
            "6. Clear the list of products\n" +
            "0. Exit\n");
                index = Convert.ToInt32(Console.ReadLine());
                switch (index)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        products.add_product();
                        break;
                    case 2:
                        products.add_food_product();
                        break;
                    case 3:
                        products.view_list();
                        break;
                    case 4:
                        products.fin_list();
                        break;
                    case 5:
                        products.fout_list();
                        break;
                    case 6:
                        products.clear_list();
                        break;
                    default:
                        break;
                }
            } while (true);
        }
    }
}
