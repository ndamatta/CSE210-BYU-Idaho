using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address[] addresses =  new Address[2];
        Customer[] customers =  new Customer[2];
        List<Product>[] productsLists = new List<Product>[2];
        Order[] orders = new Order[2];

        //ORDER 1 (USA)
        addresses[0] = new Address("613 Mertz Rapids", "Blicktown", "Alaska", "USA");
        customers[0] =  new Customer("Mr. Orrin Kiehn",addresses[0]);
        productsLists[0] = new List<Product>();
        productsLists[0].Add(new Product("Mini Pop Molds","A002",16.99f,2));
        productsLists[0].Add(new Product("20oz 3in1 Stainless Steel Powder Coated Tumbler","A001",29.99f,1));
        orders[0] = new Order(customers[0],productsLists[0]);

        //ORDER 2 (NOT USA)
        addresses[1] = new Address("impasse Margaud Martel", "Henry", "Marie-sur-Mer", "France");
        customers[1] =  new Customer("Richard Benard",addresses[1]);
        productsLists[1] = new List<Product>();
        productsLists[1].Add(new Product("Slush & Shake Maker", "A333",19.99f,3));
        productsLists[1].Add(new Product("The Art of Slush Recipe Book","A444",16.95f,1));
        productsLists[1].Add(new Product("NEW Quick Pop Maker & Accessories","A555",59.99f,2));
        orders[1] = new Order(customers[1],productsLists[1]);

        for(int i = 0; i < 2; i++)
        {
            Console.WriteLine($"\nFor Customer Number {i+1} the Order is:");
            Console.WriteLine("\nPacking Label:\n\n{0}",orders[i].GetPackingLabel()); 
            Console.WriteLine("Shipping Label:\n\n{0}",orders[i].GetShippingLabel());
            Console.WriteLine("\nTotal Cost: ${0}\n\n",orders[i].GetTotalCost());
        }
    }
}