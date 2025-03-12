using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razordemo.Pages;

public class IndexModel : PageModel
{
    public ArrayList personas = new ArrayList()
        {
            new Persona("Angel", 24, "5522987755"),
            new Persona("Jesus", 30, "5527534754"),
            new Persona("Manuel", 20, "5522987764"),
            new Persona("Braulio", 27, "5587462614"),
            new Persona("Juan", 50, "5539273827"),
            new Persona("Alonso", 33, "5558192638"),
            new Persona("Lenon", 27, "5537281728"),
            new Persona("Pablo", 57, "5528173827")
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
