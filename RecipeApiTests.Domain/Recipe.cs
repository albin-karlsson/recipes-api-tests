using Newtonsoft.Json;

namespace RecipeApiTests.Domain
{
    public class Recipe
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("ingredients")]
        public List<string> Ingredients { get; set; }

        [JsonProperty("instructions")]
        public List<string> Instructions { get; set; }

        [JsonProperty("prepTimeMinutes")]
        public int? PrepTimeMinutes { get; set; }

        [JsonProperty("cookTimeMinutes")]
        public int? CookTimeMinutes { get; set; }

        [JsonProperty("servings")]
        public int? Servings { get; set; }

        [JsonProperty("difficulty")]
        public string? Difficulty { get; set; }

        [JsonProperty("cuisine")]
        public string? Cuisine { get; set; }

        [JsonProperty("caloriesPerServing")]
        public int? CaloriesPerServing { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("userId")]
        public int? UserId { get; set; }

        [JsonProperty("image")]
        public string? Image { get; set; }

        [JsonProperty("rating")]
        public double? Rating { get; set; }

        [JsonProperty("reviewCount")]
        public int? ReviewCount { get; set; }

        [JsonProperty("mealType")]
        public List<string> MealType { get; set; }
    }
}
