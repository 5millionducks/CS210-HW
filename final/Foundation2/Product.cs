using System;

public class Product(string name, int productId, double price, int quantity)
{
    private readonly string _name = name;
    private readonly int _productID = productId;
    private readonly double _price = price;
    private readonly int _quantity = quantity;

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetProductId()
    {
        return _productID;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}