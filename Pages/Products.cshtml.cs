using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Azure.Cosmos.Samples.Web.Models;
using Microsoft.Azure.Cosmos.Samples.Web.Services;

namespace Microsoft.Azure.Cosmos.Samples.Web.Pages;

public class ProductsPageModel : PageModel
{
    private readonly ICosmosService _cosmosService;

    public IEnumerable<Product>? Products { get; set; }

    public ProductsPageModel(ICosmosService cosmosService)
    {
        _cosmosService = cosmosService;
    }

    public async Task OnGetAsync()
    {
        Products ??= await _cosmosService.RetrieveAllProductsAsync();
    }
}