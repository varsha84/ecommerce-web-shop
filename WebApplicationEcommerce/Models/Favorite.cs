using Microsoft.EntityFrameworkCore;

namespace WebApplicationEcommerce.Models;


public class Favorite{
    public int Id { get; set; }
    public int UserId{get; set;}
    public int ProductId{get; set;}
    public DateTime CreatedAt{get; set;}
}