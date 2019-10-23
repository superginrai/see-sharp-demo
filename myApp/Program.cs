using System;

namespace myApp
{

public class Item
{
    public int Number {get; set; }
    public string Type { get; set; }
    public double Cost { get; set; }
    public bool Exempt { get; set;}
    public bool Import { get; set;}
    public Item(int number, string type, double cost, bool exempt, bool import)
    {
        Number = number;
        Type = type;
        Cost = cost;
        Exempt = exempt;
        Import = import;
        
        if((exempt == false) && (import == true)){
            Cost = (cost + (cost * .15));
        }

        else if(exempt == false){
            Cost = (cost + (cost * .10));
        }

        else if(import == true){
            Cost = (cost + (cost * .05));
        }
    }
}

class Program
{
    static void Main()
    {
        Item item1 = new Item(1, "Book", 12.49, true, false);
        Item item2 = new Item(1, "Music CD", 14.99, false, false);
        Item item3 = new Item(1, "Chocolate Bar", .85, true, false);

        Console.WriteLine("{0} {1} at ${2}", item1.Number, item1.Type, item1.Cost);
        Console.WriteLine("{0} {1} at ${2}", item2.Number, item2.Type, item2.Cost);
        Console.WriteLine("{0} {1} at ${2}", item3.Number, item3.Type, item3.Cost);
        Console.WriteLine("Total: " + (item1.Cost + item2.Cost + item3.Cost));
 
        Item item4 = new Item(1, "Imported Box of Chocolates", 10.00, true, true);
        Item item5 = new Item(1, "Imported Bottle of Purfume", 47.50, false, true);

        Console.WriteLine("{0} {1} at ${2}", item4.Number, item4.Type, item4.Cost);
        Console.WriteLine("{0} {1} at ${2}", item5.Number, item5.Type, item5.Cost);
        Console.WriteLine("Total: " + (item4.Cost + item5.Cost));        
    
        Item item6 = new Item(1, "Book", 12.49, true, false);
        Item item7 = new Item(1, "Music CD", 14.99, false, false);
        Item item8 = new Item(1, "Chocolate Bar", .85, true, false);

        Console.WriteLine("{0} {1} at ${2}", item6.Number, item6.Type, item6.Cost);
        Console.WriteLine("{0} {1} at ${2}", item7.Number, item7.Type, item7.Cost);
        Console.WriteLine("{0} {1} at ${2}", item8.Number, item8.Type, item8.Cost);
        Console.WriteLine("Total: " + (item6.Cost + item7.Cost + item8.Cost));
 
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();

    }
}

}
