using System.ComponentModel.DataAnnotations;
using Microsoft.Data.SqlClient;
namespace UI;

public class customer: StoreLogin
{
    private object user;
    private object pass;

    public customer( string User, string Pass)
    {
        User = User;
        Pass = Pass;
    }
    
    public void createCustomer(customer customerToCreate)
    {
        string ConnectionString = File.ReadAllText("./ConnectionString.txt");      
        using SqlConnection connection = new SqlConnection(ConnectionString); 
        connection.Open();

        using SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Customer(UserName, PassWord) VALUES (@UserName, @PassWord)", connection);
        cmd.Parameters.AddWithValue("@UserName", customerToCreate.user);
        cmd.Parameters.AddWithValue("@PassWord", customerToCreate.pass);

        cmd.ExecuteScalar();
        connection.Close();

    }
}

