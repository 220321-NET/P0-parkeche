namespace UI;

public class DBRepository
{

public void getproduct(Product cart)
{

}

public void addproduct(Product stock)
{

}

public void createCustomer(customer user)
{
    
}

public void setproduct(Product menu)
{

}

public void createCart(Product quantity)
{

}

List<Product> cart = new List<Product>();
List<Product> stock = new List<Product>();
    public void MainMenu()
    { 
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

}
}