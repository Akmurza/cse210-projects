public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;

        _customer = customer;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"Product: {product.GetName()}, ID: {product.GetProductId()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Customer: {_customer.GetName()}\nAddress: {_customer.GetAddress().GetFullAddress()}";
    }

    public double CalculateTotalCost()
    {
        double totalProductsCost = 0;
        foreach (Product product in _products)
        {
            totalProductsCost += product.CalculateProductTotalPrice();
        }
        
        // cost by customer location
        double shippingCost = _customer.IsInUSA() ? 5 : 35;
        
        return totalProductsCost + shippingCost;
    }
}
