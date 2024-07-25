using System;

public class Order(Customer customer)
{
    private readonly List<Product> _products = [];
    private readonly Customer _customer = customer;

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        totalCost += GetShippingCost();
        return totalCost;
    }

    public double GetShippingCost()
    {
        return _customer.LocalUSA() ? 5 : 35;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += ($" {product.GetName()} (ID: {product.GetProductId()})\n");

            label += ($"Price: ${product.GetPrice()} | Quantity: {product.GetQuantity()}\n");

        }
        return label;
    }

    public string GetShippingLabel()
    {
        return ($"Shipping Label:\nCustomer Name: {_customer.GetName()}\nAddress: {_customer.GetAddress()}");
    }
}