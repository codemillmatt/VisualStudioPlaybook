namespace VSPlaybook.Models
{
    public class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }

    public class Address
    {
        int _addressId;

        public string? Line1 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }

        public void AddNewAddress(string line, string city, string state)
        {
            throw new NotImplementedException();
        }
    }
}