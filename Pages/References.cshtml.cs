using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace portfolio.Pages;

public class ReferencesModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public ReferencesModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}


