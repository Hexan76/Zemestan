using Microsoft.AspNetCore.Mvc;
using Zemestan.Controllers;

public class HomeController:ZemestanController
{
    [Route("/")]
    public IActionResult Home()
    {
        return Redirect("~/swagger");
    }
}