namespace UI;

public class Product{
    public static object Id { get; internal set; }
    public string? dateCreated {get; set;}
    public string? productName {get; set;}
    public int quantity {get; set;}
    
    public decimal price {get; set;}
}