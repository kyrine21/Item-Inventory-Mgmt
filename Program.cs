using System.Net.Http.Headers;

namespace Item_Inventory_Mgmt
{
    internal class Program
    {

        static string[] items = { "Shampoo", "Conditioner", "Soap", "Toothpaste", "Deodorant", "Mouthwash" };
        static void Main(string[] args)
        {

            Console.WriteLine("Item Inventory Management");
            Console.Write("Enter Function:\n[1] Item List\n[2] Add\n[3] Delete \n[4] Update \n");
            int functionInput = Convert.ToInt32(Console.ReadLine());

            switch (functionInput)
            {
                case 1:
                    listOfItems(items);
                    break;
            }
        }
        //static string[] items = { "Shampoo", "Conditioner", "Soap", "Toothpaste", "Deodorant", "Mouthwash" };

        static void listOfItems(string items)
        {

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[items.Length]);
            }

            static void addItem() { }

            static void deleteItem() { }

            static void updateItem() { }
        }
    }
}