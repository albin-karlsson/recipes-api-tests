using Newtonsoft.Json;

namespace RecipeApiTests.Domain
{
    public class RecipesRoot
    {
        [JsonProperty("recipes")]
        public List<Recipe> Recipes { get; set; }

        [JsonProperty("total")]
        public int? Total { get; set; }

        [JsonProperty("skip")]
        public int? Skip { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }
    }
}
