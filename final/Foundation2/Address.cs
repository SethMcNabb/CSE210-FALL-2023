class Address
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

    public bool InUSA()
    {
        if (country.ToUpper() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetAdressString()
    {
        return $"{streetAddress}\n{city}, {state} {country}";    
    }
}
