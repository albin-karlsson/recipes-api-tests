using FluentAssertions;
using RecipeApiTests.Api;

namespace RecipeApiTests.Tests
{
    public class ApiCallerTests
    {
        [Fact]
        public async Task GetRecipeTitlesAsync_ReturnsListOfRecipeTitlesAsync()
        {
            // Given
            ApiCaller apiCaller = new();

            // When
            List<string> recipeTitles = await apiCaller.GetRecipeTitlesAsync();

            // Then
            recipeTitles.Should().NotBeNull();
            recipeTitles.Count().Should().BeGreaterThan(0);
        }
    }
}
