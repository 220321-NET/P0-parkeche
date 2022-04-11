using System.Diagnostics;
using Microsoft.Data.SqlClient;
namespace UI;

internal class Cart : Program
{
    public int quantity;
    public string? product {get; set;}
    public int price {get; set;}

    public int customerID {get; set;}
    
    public int dateCreated{get; set;}

    public void CreateViewCart(Cart CreateStock)
    {
    string ConnectionString = File.ReadAllText("./ConnectionString.txt");  
    using SqlConnection connection = new SqlConnection(ConnectionString);
    connection.Open();

    SqlCommand cmd = new SqlCommand("INSERT INTO ProductName ID Price DateCeated Quantity ProducName = @productName  Quantity = @quantity ID = @Id Price = @Price DateCreated = @DateCreated", connection);

    cmd.Parameters.AddWithValue("@Product", CreateStock.product);
    cmd.Parameters.AddWithValue("@Quantity", CreateStock.quantity);
    cmd.Parameters.AddWithValue("@Price", CreateStock.price);
    cmd.Parameters.AddWithValue("@ID", CreateStock.customerID);
    cmd.Parameters.AddWithValue("@DateCreated", CreateStock.dateCreated);

    cmd.ExecuteScalar();
    connection.Close();
    }
}

