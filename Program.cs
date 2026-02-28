using System.Net.Http.Headers;
using System;
using System.Collections.Generic;

namespace Item_Inventory_Mgmt
{
    internal class Program
    {
        static List<string> itemNames = new List<string>();
        static List<int> itemStocks = new List<int>();

        static void Main(string[] args)
        {

            Console.WriteLine("Item Inventory Management");
            Console.Write("Enter Function:\n[1] Item List\n[2] Add\n[3] Delete \n[4] Update \n[5] Exit\n");
            Console.Write("Function: ");
            int functionInput = Convert.ToInt32(Console.ReadLine());

            PopulateItemsStock();

            switch (functionInput)
            {
                case 1:
                    listOfItems();
                    break;

                case 2:

                    break;
            }
        }

        static void PopulateItemsStock()
        {

            itemNames.Add("Shampoo");
            itemNames.Add("Soap");
            itemNames.Add("Toothpaste");
            itemNames.Add("Deodorant");
            itemNames.Add("Lotion");

            itemStocks.Add(20);
            itemStocks.Add(5);
            itemStocks.Add(26);
            itemStocks.Add(12);
            itemStocks.Add(2);


        }

        static void listOfItems()
        {

            Console.WriteLine("\n------------------------------------\nItems in Stock: \n------------------------------------");

            for (int i = 0; i < itemNames.Count; i++)
            {
                Console.WriteLine("- "+itemNames[i] + " " + itemStocks[i]);

            }
            static void addItem() { }

            static void deleteItem() { }

            static void updateItem() { }

        }
    }





 
        //static string[] items = { "Shampoo", "Conditioner", "Soap", "Toothpaste", "Deodorant", "Mouthwash" };

    }

