

namespace GregslistSharp.Models;

public class House
{
    public int Id {get; set;}
    public int? Year {get; set;}
    public int? Price {get; set;}
    public string Address {get; set;}
    public int? Bedrooms {get; set;}
    public int? Bathrooms {get; set;}
    public string Description {get; set;}
}