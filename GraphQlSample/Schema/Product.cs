namespace GraphQlSample.Schema;

public class Product
{
    public Guid Id { get; set; }
    public String? Name { get; set; }
    public Double? UnitPrice { get; set; }
    public int? Stock { get; set; }
}