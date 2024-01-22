using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeApiTests.Api;

namespace RecipeApiTests.UI.Pages
{
    public class IndexModel : PageModel
    {
        public List<string>? RecipeTitles { get; set; }

        public async Task OnGet()
        {
            RecipeTitles = await new ApiCaller().GetRecipeTitlesAsync();
        }
    }
}
