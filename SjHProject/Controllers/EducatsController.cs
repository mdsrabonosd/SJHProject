using Microsoft.AspNetCore.Mvc;
using SjHProject.DataFront;
using SjHProject.DataModel;

namespace SjHProject.Controllers
{

    public class EducatsController : Controller
    {
        private readonly ProjectContext _Srabon;
        public EducatsController(ProjectContext Srabon)
        {
            _Srabon = Srabon;
        }

        public IActionResult Home()
        {
            return View();
        }
       
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Furniture()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Contact(Contact Sraboon)
        {
            _Srabon.Add(Sraboon);
            _Srabon.SaveChanges();
            return RedirectToAction("Contact");

        }
        


    }
}
