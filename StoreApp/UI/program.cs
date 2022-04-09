using UI;
using Microsoft.Data.SqlClient;

//instantiate method
StoreLogin stLogin = new StoreLogin();
//calls method
stLogin.Mainlogin();//calls method      

StoreMenu stMenu = new StoreMenu();
stMenu.MainMenu();

string ConnectionString = File.ReadAllText("./ConnectionString.txt");
using SqlConnection connection = new SqlConnection(ConnectionString);

//connection.Open();

//SqlCommand cmd = new SqlCommand("SELECT*FROM StoreLogin", connection);
//SqlDataReader reader = cmd.ExecuteReader();
//while (reader.Read())
// {
// //    Console.WriteLine(reader.GetInt32(0));
//     Console.WriteLine(reader.GetString(1));
//     Console.WriteLine(reader.GetString(2));
// }