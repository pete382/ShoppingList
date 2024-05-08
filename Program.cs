//Shopping List

//create shopping list

using System.Collections.Generic;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Net.NetworkInformation;


List<string> ShopList = new List<string>();
bool CONTINUE = true;
bool yN = true;
string response = "y";


    
    // menu item with price

    Dictionary<string, decimal> Inventory = new Dictionary<string, decimal>();

    Inventory.Add("coke", (decimal)1.55);
    Inventory.Add("bread", (decimal)3.95);
    Inventory.Add("donut", (decimal)1.55);
    Inventory.Add("eggs", (decimal)3.99);
    Inventory.Add("milk", (decimal)2.99);

    foreach (KeyValuePair<string, decimal> INV in Inventory) 
    {
        Console.WriteLine(INV);

    }


do
{
    Console.WriteLine("Please add an item.");
    string NewItem = Console.ReadLine().ToLower().Trim();
    foreach (KeyValuePair<string, decimal> I in Inventory)
    {
        if (I.Key == NewItem)
        {
            ShopList.Add(NewItem);

            Console.WriteLine("Do you want to add another item ? Type 'y' for yes and 'n' for no.");
            response = Console.ReadLine().ToLower().Trim();
            if (response == "y")
            {
                CONTINUE = true; break;

            }
            else if (response == "n")

            {
                CONTINUE = false;
                break;
            }
            break;
            
;        }
        //else if (I.Key != NewItem)
        //{
        //    Console.WriteLine($"Please reference only the items appearing on the list.");
        //    CONTINUE = true;
        //    break;
        //}

    }
} while (CONTINUE == true);



//    if (I.Key != NewItem)

//    while(yN)
//    {   yN = false;    
//        CONTINUE = true;
//        Console.WriteLine($"Please reference only the items appearing on the list.{Inventory.Count}");
//         break;
//        //Console.WriteLine("Please use 'y' for yes and 'n' for no.");

//    }




foreach (string S in ShopList)
{
    Console.WriteLine(S);

}