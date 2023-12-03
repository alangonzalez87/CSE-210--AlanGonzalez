using System;
using System.Collections.Generic;
using System.Text;

class Address
{
    public string Street { get; }
    public string City { get; }
    public string State { get; }
    public string Country { get; }

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public bool IsUs()
    {
        return Country.ToLower() == "arg";
    }

    public string GetFullAddress()
    {
        return $"{Street}\n{City}, {State}\n{Country}";
    }
}

class Customer
{
    public string Name { get; }
    public Address Address { get; }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public bool IsUsCustomer()
    {
        return Address.IsUs();
    }
}

class Product
{
    public string Name { get; }
    public string ProductId { get; }
    public decimal Price { get; }
    public int Quantity { get; }

    public Product(string name, string productId, decimal price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public decimal CalculateTotalPrice()
    {
        return Price * Quantity;
    }
}

class Order
{
    public List<Product> Products { get; }
    public Customer Customer { get; }

    public Order(List<Product> products, Customer customer)
    {
        Products = products;
        Customer = customer;
    }

    public decimal CalculateTotalCost()
    {
        decimal shippingCost = Customer.IsUsCustomer() ? 5 : 35;
        decimal totalPrice = Products.Sum(product => product.CalculateTotalPrice());
        return totalPrice + shippingCost;
    }

    public string GeneratePackagingLabel()
    {
        var packagingLabel = new StringBuilder();
        foreach (var product in Products)
        {
            packagingLabel.AppendLine($"{product.Name} - {product.ProductId}");
        }
        return packagingLabel.ToString();
    }

    public string GenerateShippingLabel()
    {
        return $"{Customer.Name}\n{Customer.Address.GetFullAddress()}";
    }
}

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 calle barista", "mar del plata", "bs as", "arg");
        Customer customer1 = new Customer("Alan Gonzalez", address1);
        Product product1 = new Product("Computer", "W001", 10.99m, 2);
        Product product2 = new Product("Radio", "G002", 24.99m, 1);
        Order order1 = new Order(new List<Product> { product1, product2 }, customer1);

        Address address2 = new Address("456 calle pianis", "Buenos Aires", "Bs As", "Arg");
        Customer customer2 = new Customer("Juan Pedro", address2);
        Product product3 = new Product("Notebook", "T003", 15.99m, 3);
        Order order2 = new Order(new List<Product> { product3 }, customer2);

        // Mostrar resultados
        Console.WriteLine("Pedido 1:");
        Console.WriteLine("Precio Total: " + order1.CalculateTotalCost());
        Console.WriteLine("Etiqueta de Embalaje:\n" + order1.GeneratePackagingLabel());
        Console.WriteLine("Etiqueta de Envío:\n" + order1.GenerateShippingLabel());

        Console.WriteLine("\nPedido 2:");
        Console.WriteLine("Precio Total: " + order2.CalculateTotalCost());
        Console.WriteLine("Etiqueta de Embalaje:\n" + order2.GeneratePackagingLabel());
        Console.WriteLine("Etiqueta de Envío:\n" + order2.GenerateShippingLabel());
    }
}
