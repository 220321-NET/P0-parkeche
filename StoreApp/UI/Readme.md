TO DO LIST
product
    name
    cost
cart
    product
    total

database
    connect to databse

customer class
    take inlogin infopublic int SetDatabaseInventory(Product value)
    {
        using SqlConnection connection = new SqlConnection(_connectionString);
        connection.Open();

        SqlCommand cmd = new SqlCommand("SELECT * FROM Inventory", connection);

        cmd = new SqlCommand("UPDATE Inventory SET QuantityInventory = @IUpdate WHERE InventoryId = @id", connection);

        cmd.Parameters.AddWithValue("@IUpdate", value.Amount);
        cmd.Parameters.AddWithValue("@id", value.Id);

        cmd.ExecuteScalar();

        cmd = new SqlCommand("SELECT * FROM Inventory WHERE ProductID = " + $"{value.Id}", connection);
        SqlDataReader dataReader = cmd.ExecuteReader();

        if (dataReader.Read())
        {
            value.Amount = dataReader.GetInt32(2);
        }
        dataReader.Close();
        connection.Close();

        return value.Amount;
    }

    public void CreateCustomer(Customer customerToCreate) 
    {
        using SqlConnection connection = new SqlConnection(_connectionString);
        connection.Open();

        using SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Customer(Username, Password) VALUES (@Username, @Password)", connection);

        cmd.Parameters.AddWithValue("@UserName", customerToCreate.User);
        cmd.Parameters.AddWithValue("@PassWord", customerToCreate.Pass);

        cmd.ExecuteScalar();
        connection.Close();
    }

