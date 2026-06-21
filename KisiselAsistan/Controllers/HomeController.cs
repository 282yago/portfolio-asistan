using KisiselAsistan.Models;
using KisiselAsistan.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KisiselAsistan.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hakkımda()
        {
            var model = new HakkimdaViewModel();

            model.Ad = "Yağız";
            model.Soyad = "Tekin";
            model.Sehir = "Kocaeli";
            model.Universite = "Bandırma 17 Eylül Üniversitesi";
            model.Unvan = "Yazılım Mühendisi & Geliştirici";
            model.Ozet = "Merhaba! Ben Yağız Tekin, yazılım dünyasında tutkulu bir yolculuğa çıkan bir yazılım mühendisi ve geliştiricisiyim. " +
                "Teknolojiye olan ilgim, çocukluk yıllarıma kadar uzanır ve bu tutku beni sürekli olarak yeni beceriler öğrenmeye ve projeler geliştirmeye yönlendirdi. " +
                "Yazılım geliştirme alanında uzmanlaşarak, kullanıcı dostu ve etkili çözümler sunmayı hedefliyorum. " +
                "Takım çalışmasına önem veren, yenilikçi ve çözüm odaklı bir profesyonel olarak, her projede en iyi sonuçları elde etmek için çaba gösteriyorum.";
            model.Email = "yagiz1905tekin@gmail.com";
            model.Telefon = "0537 587 3128";
            model.GitHub = "https://github.com/282yago";
            model.İnstagram = "https://www.instagram.com/yagiztkn_/";
            model.LinkedIn = "https://www.linkedin.com/in/yagiztekin-software/";
            model.Teknolojiler = new List<string> { "C#", "ASP.NET Core" };

            model.Projeler = new List<ProjeViewModel>
            {
                new ProjeViewModel
                {
                    Ad = "Proje 1",
                    Aciklama = "Proje 1 açıklaması",
                    Teknolojiler = new List<string> { "C#", "ASP.NET Core" },
                    GitHubUrl = "https://github.com/282yago/proje1",
                    CanlıUrl = "https://proje1.com"
                },

                 new ProjeViewModel
                {
                    Ad = "Proje 2",
                    Aciklama = "Proje 2 açıklaması",
                    Teknolojiler = new List<string> { "C#", "ASP.NET Core" },
                    GitHubUrl = "https://github.com/282yago/proje2",
                    CanlıUrl = "https://proje2.com"
                },

                   new ProjeViewModel
                {
                    Ad = "Proje 3",
                    Aciklama = "Proje 3 açıklaması",
                    Teknolojiler = new List<string> { "C#", "ASP.NET Core" },
                    GitHubUrl = "https://github.com/282yago/proje3",
                    CanlıUrl = "https://proje3.com"
                }
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
