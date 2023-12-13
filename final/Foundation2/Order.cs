using System.ComponentModel.DataAnnotations;

class Order
{
    public List<Product> products;
    private Customer customer;

   private double shippingFee = 35.00; 
    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct (Product product)
    {
        products.Add(product);
    }

    public double OrderTotal()
    {
        double total = 0;

        foreach (Product product in products)
        {
            total += product.CalculatePrice();
        }
        
        if  (customer.IsInUSA())
        {
            shippingFee = 5.00;
        }
        return total + shippingFee;
    }
    public string PackingLabel()
    {
        return string.Join("\n", products.Select(p => $"{p.name} - {p.productId}"));
    }

    public string ShippingLabel()
    {
        return $"{customer.Display()}";
    }

}