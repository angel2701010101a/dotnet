using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Finally.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public DataSet dts;
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        dts = GetData();
    }

    public DataSet GetData(){
        DataSet dts = new DataSet();
        dts.ReadXml("/data/Alumno.xml");
        return dts;
    }

    public void OnGet()
    {

    }
    }
