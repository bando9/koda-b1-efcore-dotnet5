
namespace KodaStore.Api.Models;

public sealed class Product
{
    // [Required]
    // [StringLength(30)]
    public string ProductCode { get; private set;}
    public string Name { get; private set;}
    public decimal Price { get; private set;}
    public int Stock { get; private set;}
    public string? Description { get; private set;}
    public ICollection<OrderItem> OrderItems {get; private set;} = new List<OrderItem>();
    
    // FK Category
    public long CategoryId { get; private set;}
    public Category Category {get; private set;}


    public Product(string productCode, string name, decimal price, int stock,long categoryId,string? description = null)
    {
        if (string.IsNullOrWhiteSpace(productCode) || productCode.Trim().Length > 30)
        {
            throw new ArgumentException("Product code is Required, Max 30 Character", nameof(productCode));
        }
        if (string.IsNullOrWhiteSpace(name) || productCode.Trim().Length > 120)
        {
            throw new ArgumentException("Product code is Required", nameof(name));
        }
        if (price <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(price), "Price cannot be zero or negative ");
        }
        if (stock < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(stock), "stock cannot be negative");
        }
       
        ProductCode = productCode.Trim().ToUpperInvariant();
        Name = name;
        Price = price;
        Stock = stock;
        Description = description?.Trim();
        CategoryId = categoryId;
    }

    public void UpdateDetail(string name,decimal price, int stock, long categoryId,string? description)
    {
        var validated = new Product(ProductCode, name, price, stock, categoryId, description);

        Name = validated.Name;
        Price = validated.Price;
        Stock = validated.Stock;
        CategoryId=validated.CategoryId;
        Description=validated.Description;
    }

    
}