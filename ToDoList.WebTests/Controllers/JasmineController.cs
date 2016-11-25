using System;
using System.Web.Mvc;

namespace ToDoList.WebTests.Controllers
{
    public class JasmineController : Controller
    {
        public ViewResult Run()
        {
            return View("SpecRunner");
        }
    }
}
