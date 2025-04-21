namespace Shopping_List_Lab;

class Program
{
    static void Main(string[] args)
    {
        /* 1. Display at least 8 item names and prices
         */
        
        Dictionary<string, double> menuList = new Dictionary<string, double>();

        menuList["Vegan Kimchi"] = 5.96;
        menuList["Veggie Blend Cheerios"] = 4.54;
        menuList["Protein Greek Yogurt"] = 6.48;
        menuList["Vanilla Almond Milk"] = 4.99;
        menuList["Shin Ramen"] = 12.92;
        menuList["Dark Chocolate"] = 1.53;
        menuList["Organic Pineapple"] = 2.37;
        menuList["Organic Blueberries"] = 3.55;
        
        Console.WriteLine("Menu Items & Prices");
        Console.WriteLine("------------------");
        
        foreach (KeyValuePair<string, double> anEntry in menuList)
        {
            Console.WriteLine("---------");
            Console.WriteLine($"{anEntry.Key}: ${anEntry.Value}");
        }
/*  2. Ask the user to enter an item name
     2a. If that item exists, display that item and price
       add that item to the user’s order.
    2b. If that item doesn’t exist, display an error and re-prompt the user.  
         (Display the menu again if you’d like.) 
 */
        Console.WriteLine("Enter an item");
        
        if ()
      
        {
         
            string shoppingList = Console.ReadLine(); 
            
        }
        
        
    }
}