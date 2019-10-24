using System;
using System.Linq;
using System.Collections.Generic;

namespace myApp
{

public class Item
{
    public int Number { get; set; }
    public string Type { get; set; }
    public double Cost { get; set; }
    public bool Exempt { get; set; }
    public bool Import { get; set; }
    public double Tax { get; set; }
    public Item(int number, string type, double cost,  double tax, bool exempt, bool import)
    {
        Number = number;
        Type = type;
        Cost = cost;
        Tax = tax;
        Exempt = exempt;
        Import = import;
 
        
        if((exempt == false) && (import == true)){
            Cost = (cost + (cost * .15));
            Tax = (tax + (cost * .15));
        }
        else if(exempt == false){
            Cost = (cost + (cost * .10));
            Tax = (tax + (cost * .10));
        }
        else if(import == true){
            Cost = (cost + (cost * .05));
            Tax = (tax + (cost * .05));
        }
    }
}

class Program
{
    static void Main()
    
    {
        var basket1 = new List<Item>()
            {   
            new Item(1, "Book", 12.49, 0, true, false),
            new Item(1, "Music CD", 14.99, 0, false, false),
            new Item(1, "Chocolate Bar", .85, 0, true, false)
            };
        foreach (var item in basket1)
        {
        Console.WriteLine("{0} {1}: {2}", item.Number, item.Type, Math.Round(item.Cost, 2, MidpointRounding.ToEven));
        }
        double totalTax1 = basket1.Sum(item => item.Tax);
        Console.WriteLine("Sales Taxes: " + Math.Round(totalTax1, 2, MidpointRounding.ToEven));
        double basketTotal1 = basket1.Sum(item => item.Cost);
        Console.WriteLine("Total: " + (Math.Round(basketTotal1, 2, MidpointRounding.ToEven))
        + Environment.NewLine);      

        var basket2 = new List<Item>()
            {   
            new Item(1, "Imported Box of Chocolates", 10.00, 0, true, true),
            new Item(1, "Imported Bottle of Purfume", 47.50, 0, false, true)
            };
        foreach (var item in basket2)
        {
        Console.WriteLine("{0} {1}: {2}", item.Number, item.Type, Math.Round(item.Cost, 2, MidpointRounding.ToEven));
        }
        double totalTax2 = basket2.Sum(item => item.Tax);
        Console.WriteLine("Sales Taxes: " + Math.Round(totalTax2, 2, MidpointRounding.ToEven));
        double basketTotal2 = basket2.Sum(item => item.Cost);
        Console.WriteLine("Total: " + (Math.Round(basketTotal2, 2, MidpointRounding.ToEven))
        + Environment.NewLine);          

        var basket3 = new List<Item>()
            {   
            new Item(1, "Imported Bottle of Perfume", 27.99, 0, false, true),
            new Item(1, "Bottle of Perfume", 18.99, 0, false, false),
            new Item(1, "Packet of Headache Pills", 9.75, 0, true, false),
            new Item(1, "Imported Box of Chocolates", 11.25, 0, true, true)
            };
        foreach (var item in basket3)
        {
        Console.WriteLine("{0} {1}: {2}", item.Number, item.Type, Math.Round(item.Cost, 2, MidpointRounding.ToEven));
        }
        double totalTax3 = basket3.Sum(item => item.Tax);
        Console.WriteLine("Sales Taxes: " + Math.Round(totalTax3, 2, MidpointRounding.ToEven));
        double basketTotal3 = basket3.Sum(item => item.Cost);
        Console.WriteLine("Total: " + (Math.Round(basketTotal3, 2, MidpointRounding.ToEven))
        + Environment.NewLine);    

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();

    }
}

}