using Microsoft.AspNetCore.Mvc;

namespace AgenciaViagem1.Controllers;

public class UsuariosController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}