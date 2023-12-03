using System;
using System.Collections.Generic;
using System.Text;


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
