using Bogus;

namespace GraphQlSample.Schema;

public class Query
{
    public IEnumerable<Category> GetCategories()
    {
        Faker<Category> categoryFaker = new Faker<Category>();
        List<Category> categories = categoryFaker.Generate(5);
        return categoryFaker.Generate(5);
    }

    [GraphQLDeprecated("This query is deprecated")]
    public String Test => "This is a test case. Check if GraphQL is working";
}