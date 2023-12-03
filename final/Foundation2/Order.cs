using System;
using System.Collections.Generic;
using System.Text;

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
