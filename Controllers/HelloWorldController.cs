using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index(string name)
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public IActionResult Welcome(string name, int numTimes = 2)
    {
        ViewData["MyMessage"] = "Howdy, " + HtmlEncoder.Default.Encode(name).ToString();
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}