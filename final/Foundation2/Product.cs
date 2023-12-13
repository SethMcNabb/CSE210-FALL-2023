class Product
{
    public string name;
    public int productId;
    public double price;
    public int quantity;

    public Product(string name, int productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public double CalculatePrice()
    {
        return price * quantity;
    }
}
