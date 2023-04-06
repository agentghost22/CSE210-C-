using System;


public class Address
{
    private string streetAddress;
    private string city;
    private string state;
    private string country;

    public Address(string streetAddress, string city, string state, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return this.country == "USA";
    }

    public string GetFullAddress()
    {
        return $"{this.streetAddress}\n{this.city}, {this.state} {this.country}";
    }
}

public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool IsInUSA()
    {
        return this.address.IsInUSA();
    }

    public string GetName()
    {
        return this.name;
    }

    public Address GetAddress()
    {
        return this.address;
    }
}

public class Product
{
    private string name;
    private int productId;
    private decimal price;
    private int quantity;

    public Product(string name, int productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public decimal GetPrice()
    {
        return this.price * this.quantity;
    }

    public int GetProductId()
    {
        return this.productId;
    }

    public string GetName()
    {
        return this.name;
    }
}

public class Order
{
    private Customer customer;
    private Product[] products;

    public Order(Customer customer, Product[] products)
    {
        this.customer = customer;
        this.products = products;
    }

    public decimal GetTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (Product product in this.products)
        {
            totalPrice += product.GetPrice();
        }

        if (this.customer.IsInUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string label = "";
        for (int i = 0; i < products.Length; i++)
        {
            var product = this.products[i];
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        Customer customer = this.customer;
        Address address = customer.GetAddress();
        string label = $"{customer.GetName()}\n{address.GetFullAddress()}";
        return label;
    }
}

public class Program
{
    private static Product[] customer2products;

    static void Main()
    {
        Address customer1Address = new Address("1401 old fish road", "Monroe", "NC", "USA");
        Customer customer1 = new Customer("Luke Edwards", customer1Address);
        Product[] customer1Products = new Product[] {
            new Product("Tablet Case", 1, 10, 2),
            new Product("Fishing Pole", 2, 20, 1),
            new Product("Fishing Luers", 3, 30, 3)
        };
        Order customer1Order = new Order(customer1, customer1Products);
        Console.WriteLine("Tablet, Fishing Pole, Fishing Luers:");
        Console.WriteLine("Luke Edwards");
        Console.WriteLine(customer1Order.GetPackingLabel());
        Console.WriteLine("1401 Old Fish Road", "Monroe", "NC", "USA");
        Console.WriteLine(customer1Order.GetShippingLabel());
        Console.WriteLine("Total Price: $" + customer1Order.GetTotalPrice());

        Console.WriteLine();

        Address customer2Address = new Address("1301 spring St.", "Monroe", "NC", "USA");
        Customer customer2 = new Customer("Jeffrey Guinea", customer2Address);
        Product[] customer2products = new Product[]{
            new Product("Nike Pro Compressions", 1, 10, 2),
            new Product("Nike Socks", 2, 20, 1),
            new Product("Nike HYperVenom 3.0", 3, 30, 3)
        };
        Order customer2Order = new Order(customer2, customer2products);
        Console.WriteLine("Nike Pro Compression, Nike Socks, Nike Hypervenom:");
        Console.WriteLine("Jeffrey Guinea");
        Console.WriteLine(customer2Order.GetPackingLabel());
        Console.WriteLine("1301 spring St", "Monroe","NC", "USA");
        Console.WriteLine(customer2Order.GetShippingLabel());
        Console.WriteLine("Total Price: $" + customer2Order.GetTotalPrice());

        Console.WriteLine();

    }
}