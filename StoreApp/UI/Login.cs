global using System;
using UI;
using System.Collections.Generic;
using System.Diagnostics;

namespace UI;

public class StoreLogin
{
    string user{get; set;}
    string Pass{get; set;}
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
        }
    else{
            Console.WriteLine("Enter a Username");
            string? User = Console.ReadLine();
            Console.WriteLine("Enter a Password");
            string? Pass = Console.ReadLine();
        } 
    }

}