namespace IWantApp.Domain.Products;

public class Product : Entity
{
    public Category Category { get; set; }
    public string Description { get; set; }
    public bool HasStrock { get; set; }
}
