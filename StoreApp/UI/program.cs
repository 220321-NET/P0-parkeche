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

connection.Open();

SqlCommand cmd = new SqlCommand("SELECT*FROM StoreLogin WHERE ID", connection);
SqlDataReader reader = cmd.ExecuteReader();
