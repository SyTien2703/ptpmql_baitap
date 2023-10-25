using Microsoft.AspNetCore.Mvc;
namespace FirstWebMVC.Controllers
//Giai phuong trinh bac nhat
{
    public class PhuongTrinhBacNhatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
// Nguyễn Sỹ Tiến - 2021050637
        [HttpPost]
        public IActionResult Index(double a, double b)
        {
            if (a == 0)
            {
            if (b==0)
                {
                      ViewBag.ThongBao = "Phuong trinh co vo so nghiem";
                }else 
                {
                    ViewBag.ThongBao = "Phuong trinh vo nghiem";
                }

            }else
            {
                double nghiem = -b / a;
               ViewBag.ThongBao =  $"Nghiem cua phuong trinh la x = {nghiem}";
            } 


            return View();
        }
    }
}