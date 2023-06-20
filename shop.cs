using System;
using System.Collections.Generic;

// Base class representing a product
public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Product: {Name}, Price: {Price:C}");
    }
}

// Derived class representing an electronic product
public class ElectronicProduct : Product
{
    public string Brand { get; set; }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Brand: {Brand}");
    }
}

// Derived class representing a clothing product
public class ClothingProduct : Product
{
    public string Size { get; set; }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Size: {Size}");
    }
}

// Shopping cart class
public class ShoppingCart
{
    private List<Product> items;

    public ShoppingCart()
    {
        items = new List<Product>();
    }

    public void AddItem(Product product)
    {
        items.Add(product);
        Console.WriteLine($"Added {product.Name} to the shopping cart.");
    }

    public void DisplayCart()
    {
        Console.WriteLine("Shopping Cart:");
        foreach (Product item in items)
        {
            item.DisplayInfo();
        }
    }
}

// Usage example
class Program
{
    static void Main(string[] args)
    {
        // Object creation - Creating instances of classes
        ShoppingCart cart = new ShoppingCart();

        Product product = new Product(); // Object creation
        product.Name = "Lenovo";
        product.Price = 77000;
        cart.AddItem(product);

        ElectronicProduct electronicProduct = new ElectronicProduct(); // Object creation
        electronicProduct.Name = "Samsung Tablet";
        electronicProduct.Price = 0.55m;
        electronicProduct.Brand = "Samsung";
        cart.AddItem(electronicProduct);

        ClothingProduct clothingProduct = new ClothingProduct(); // Object creation
        clothingProduct.Name = "Apple";
        clothingProduct.Price = 0.79m;
        electronicProduct.Brand = "Samsung";
        cart.AddItem(clothingProduct);

 ClothingProduct clothingProduct = new ClothingProduct(); // Object creation
        clothingProduct.Name = "T-shirts";
        clothingProduct.Price = 0.019m;
        clothingProduct.Size = "L";
        cart.AddItem(clothingProduct);
        cart.DisplayCart();
    }
}
