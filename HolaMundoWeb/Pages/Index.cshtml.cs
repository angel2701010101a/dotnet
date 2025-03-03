using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolaMundoWeb.Pages;

public class IndexModel : PageModel
{
    public ArrayList Datos {set; get;}= new();



    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        for(int i=0; i<10; i++){
            Datos.Add(" algo");
        }
    }
}
