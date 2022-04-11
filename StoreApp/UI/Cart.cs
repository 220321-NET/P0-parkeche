using Microsoft.Data.SqlClient;
namespace UI;

internal class Cart
{
    public int quantity;
    public string? product {get; set;}
    public int price {get; set;}

    public int customerID {get; set;}

public int CreateStock(Cart CreateStock)
{
    string ConnectionString = File.ReadAllText("./ConnectionString.txt");  
    using SqlConnection connection = new SqlConnection(ConnectionString);
    connection.Open();

//     SqlCommand cmd = new SqlCommand("SELECT * FROM Menu", connection);
//     cmd = new SqlCommand("UPDATE Inventory SET QuantityInventory = @IUpdate WHERE ProductName = @product", connection);

//     cmd.Parameters.AddWithValue("@IUpdate", CreateStockInventory.quantity);
//     cmd.Parameters.AddWithValue("@name", CreateStockInventory.product);

//     cmd.ExecuteScalar();

//     cmd = new SqlCommand("SELECT * FROM Menu WHERE Product = " + $"{CreateStockInventory.price}", connection);
//     SqlDataReader dataReader = cmd.ExecuteReader();

    
//         if (dataReader.Read())
//         {
//             CreateStockInventory.price = dataReader.GetInt32(2);
//         }
//         dataReader.Close();
//         connection.Close();

//         return CreateStockInventory.price;
// }
}
