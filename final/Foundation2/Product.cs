public class Product
{
    private string _name;
    private string _productId;
    private float _pricePerUnit;
    private int _quantity;

    public Product(string name, string productId, float pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public float CalculateProductTotal()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }
}