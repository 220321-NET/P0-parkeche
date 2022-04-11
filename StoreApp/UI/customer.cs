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
}

