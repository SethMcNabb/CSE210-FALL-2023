class Customer
{
    public string name { get; set; }
    public Address address { get; set; }

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool IsInUSA()
    {
        return address.InUSA();
    }
    
    public string Display()
    {
        return $"{name} - {address.GetAdressString()}";
    }
}
