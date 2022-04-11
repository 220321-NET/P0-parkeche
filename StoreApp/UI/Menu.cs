global using System;
using Microsoft.Data.SqlClient;
namespace UI;

public class StoreMenu
{
    //making a list of cart and inventory inside the store
    List<Product> cart = new List<Product>();
    List<Product> stock = new List<Product>();
    public void MainMenu()
    { 
        //Creating Products; the bottle itself
        Product Hennessey = new Product();
        Product Captain_Morgan = new Product();
        Product Jameson = new Product();
        Product Crown_Royal = new Product();
        Product Jack_Daniel = new Product();

        // putting things inside the bottle
        Hennessey.productName = "Hennessey";
        Captain_Morgan.productName = "Captain Morgan";
        Jameson.productName = "Jameson";
        Crown_Royal.productName = "Crown Royal";
        Jack_Daniel.productName = "Jack Daniel";

        //putting a quantity to the bottles
        Hennessey.quantity = 50;
        Captain_Morgan.quantity = 50;
        Jameson.quantity = 50;
        Crown_Royal.quantity = 50;
        Jack_Daniel.quantity = 50;

        //putting price onto the bottles
        Hennessey.price = 30.00M;
        Captain_Morgan.price = 15.00M;
        Jameson.price = 20.00M;
        Crown_Royal.price = 30.00M;
        Jack_Daniel.price = 20.00M;

        //putting products in the stock
        stock.Add(Hennessey);
        stock.Add(Captain_Morgan);
        stock.Add(Jameson);
        stock.Add(Crown_Royal);
        stock.Add(Jack_Daniel);

        bool exit = false;
        do
        {
             // main menu options
            Console.WriteLine("Welcome! Choose an option from the Menu!");
            // need to show list for main menu
            Console.WriteLine("[1] Buy Product");
            Console.WriteLine("[2] View Cart");
            Console.WriteLine("[3] view Order History");
            Console.WriteLine("[x] exit");
            string? input = Console.ReadLine();

            switch (input)
            {   
                case "1":
                    buyProduct();
                break;

                case "2":
                    viewCart();
                break;

                case "3":
                    viewHistory();
                break;

                case "x":
                Console.WriteLine("[x] Exit");
                Console.WriteLine("Enjoy!");
                exit = true;
                break;

                default:
                Console.WriteLine("Invalid input! try again!");
                break;
                
            }
        }   while (!exit);
    } 
    private void viewHistory()
    {
        foreach(Product p in cart)
        {
            Console.WriteLine($"{p.productName}: quantity: {p.quantity}, price: {p.price}");
        }  
    }
    private void viewCart()
    {
        foreach(Product p in cart)
        {
            Console.WriteLine($"{p.productName}: quantity: {p.quantity}, price: {p.price}");
        }
    }
    public void buyProduct()
    
    {
        Console.WriteLine("Select the product you wish to purchase");
        int counter = 0;
        foreach(Product p in stock)
        {
            Console.WriteLine($"[{counter}] {p.productName}: quantity: {p.quantity}, price: {p.price}");
            counter = counter + 1;
        }
        string input = Console.ReadLine();
        int intInput = Int32.Parse(input);
        
        Console.WriteLine("How many would you like to purchase?");
        string quantity = Console.ReadLine();
        int quantityInput = Int32.Parse(quantity);

        cart.Add(
            new Product{
                productName = stock[intInput].productName,
                price = stock[intInput].price * quantityInput,
                quantity = quantityInput
            }
        ); 
    }
    public int CreateCart (Cart viewCart)
    {
    string ConnectionString = File.ReadAllText("./ConnectionString.txt");  
    using SqlConnection connection = new SqlConnection(ConnectionString);
    connection.Open();

    SqlCommand cmd = new SqlCommand("SELECT * FROM Menu", connection);
    cmd = new SqlCommand("UPDATE Stock SET Product = @IUpdate Quantity = @product", connection);

    cmd.Parameters.AddWithValue("@IUpdate", viewCart.inventory);
    cmd.Parameters.AddWithValue("@Product", viewCart.quantity);

    cmd.ExecuteScalar();

    cmd = new SqlCommand("SELECT * FROM Menu WHERE Stock = " + $"{viewCart.price}", connection);
    SqlDataReader dataReader = cmd.ExecuteReader();

    
//         if (dataReader.Read())
//         {
//             CreateStockInventory.price = dataReader.GetInt32(2);
//         }
//         dataReader.Close();
//         connection.Close();

    return CreateCart();
    }
}


