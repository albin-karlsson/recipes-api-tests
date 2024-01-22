using RecipeApiTests.Api;

namespace RecipeApiTests.Tests
{
    public class ApiCallerTests
    {
        [Fact]
        public async Task GetRecipes_ReturnsListOfRecipesAsync()
        {
            // Given
            ApiCaller apiCaller = new();
            HttpClient client = new();
            string url = "https://dummyjson.com/recipes";

            // When

            HttpResponseMessage response = await client.GetAsync("https://dummyjson.com/recipes");
            string json = await response.Content.ReadAsStringAsync();


            //string json = await client.GetStringAsync(url);

            // Then
        }
    }
