global using System;
using UI;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Data.SqlClient;

namespace UI;


public class StoreLogin
{
    public string User { get; private set; }
    public string Pass { get; private set; }

    // method below//
    public void Mainlogin()
    {
        //welcome menu//
        Console.WriteLine("Hello, Welcome to my Store! Are you a new customer?");
        Console.WriteLine("\n[Y] or [N]\n");
        string? input = Console.ReadLine();
        char responseChar = input.ToUpper()[0];
        if (responseChar == 'N')
        {
            //if statement for login information//
            Console.WriteLine("Enter Username");
            string? User = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string? Pass = Console.ReadLine();
            customer newCustomer = new customer(User, Pass);
        }
        else{
            Console.WriteLine("Enter a Username");
            string? User = Console.ReadLine();
            Console.WriteLine("Enter a Password");
            string? Pass = Console.ReadLine();
            customer newCustomer = new customer(User, Pass);
        } 
    }
    // public void createCustomer(customer customerToCreate)
    // {
    //     string ConnectionString = File.ReadAllText("./ConnectionString.txt");      
    //     using SqlConnection connection = new SqlConnection(ConnectionString); 
    //     connection.Open();

    //     using SqlCommand cmd = new SqlCommand("INSERT INTO StoreLogin(UserName, PassWord) VALUES (@UserName, @PassWord)", connection);
    //     cmd.Parameters.AddWithValue("@UserName", customerToCreate.User);
    //     cmd.Parameters.AddWithValue("@PassWord", customerToCreate.Pass);
    //     customer newCustomer = new customer(User, Pass);
    //     cmd.ExecuteScalar();
    //     connection.Close();
    // }
}