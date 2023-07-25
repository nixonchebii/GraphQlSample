namespace GraphQlSample.Schema;

public class Category
{
    public Guid Id { get; set; }
    public String? Name { get; set; }
    public IEnumerable<Product>? Products { get; set; }
}