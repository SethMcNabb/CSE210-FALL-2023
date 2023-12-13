class Address
{
    private string streetAddress;
    private string city;
    private string state;

    public Address(string streetAddress, string city, string state)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.state = state; 
    }
    public string GetAddressString()
    {
        return $"{streetAddress}\n{city}, {state}";    
    }
}