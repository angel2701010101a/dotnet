using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razordemo.Pages;

public class IndexModel : PageModel
{
    public ArrayList personas = new ArrayList()
        {
            new Persona("angel", 24, "5522987755")
        };
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        
    }
}
