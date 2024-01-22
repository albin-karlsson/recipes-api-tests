namespace RecipeApiTests.Api
{
    public static class ApiInitializer
    {
        // URL
        // HttpClient

        public static HttpClient MainClient { get; } = new()
        {
            BaseAddress = new Uri("https://dummyjson.com/")
        };
    }
}
