using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using criando_repositorio_1.Models;

namespace criando_repositorio_1.Controllers;

public class MarcusController : Controller{     
    public IActionResult Index()
    {
        return View();
    }

}

