using Microsoft.AspNetCore.Mvc;

namespace ParolaOlusturucu.Controllers
{
    public class ParolaUreticisiController : Controller
    {
        static Random rnd = new Random();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Uret(int uzunluk)
        {
            string havuz = "abcdefghijklmnoprstuvyzqwxABCDEFGHIJKLMNOPRSTUVYZQWX0123456789!@#$%^&*";
            string sonuc = "";
            for (int i = 0; i < uzunluk; i++)
            {
                sonuc += havuz[rnd.Next(havuz.Length)];
            }
            return Content(sonuc);
        }
    }
}
