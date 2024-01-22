
using Newtonsoft.Json;
using RecipeApiTests.Domain;

namespace RecipeApiTests.Api
{
    public class ApiCaller
    {
        public async Task<List<string>> GetRecipeTitlesAsync()
        {
            HttpResponseMessage response = await ApiInitializer.MainClient.GetAsync("recipes");

            string json = await response.Content.ReadAsStringAsync();

            RecipesRoot recipesRoot = JsonConvert.DeserializeObject<RecipesRoot>(json);

            return recipesRoot.Recipes.Select(r => r.Name).ToList();
        }
    }
}
