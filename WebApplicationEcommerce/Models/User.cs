namespace WebApplicationEcommerce.Models;
public class User{
    public int Id{get; set;}
    public string Address{get; set;}
    public int Zipcode{get; set;}
    public string City{get; set;}
    public string Status{get; set;}
    public string Country{get; set;}
    public DateTime CreatedAt{get;set;}
}