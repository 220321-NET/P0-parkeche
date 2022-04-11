using UI;
using Microsoft.Data.SqlClient;

string ConnectionString = File.ReadAllText("./ConnectionString.txt");
//instantiate method
StoreLogin stLogin = new StoreLogin();
//calls method
stLogin.Mainlogin();//calls method      

StoreMenu stMenu = new StoreMenu();
stMenu.MainMenu();


using SqlConnection connection = new SqlConnection(ConnectionString);
connection.Open();
SqlCommand cmd = new SqlCommand();
SqlDataReader reader = cmd.ExecuteReader();
connection.Close();