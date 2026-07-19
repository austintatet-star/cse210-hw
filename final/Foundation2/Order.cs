using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float CalculateTotalCost()
    {
        float total = 0;
        foreach (Product product in _products)
        {
            total += product.CalculateProductTotal();
        }

        if (_customer.IsFromUsa())
        {
            total += 5.00f;
        }
        else
        {
            total += 35.00f;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "PACKING LABEL:\n";
        foreach (Product product in _products)
        {
            label += $"Product: {product.GetName()} (ID: {product.GetProductId()}) - {product.GetFormattedPrice()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "SHIPPING LABEL:\n";
        label += $"{_customer.GetName()}\n{_customer.GetFullAddress()}\n";
        return label;
    }
}