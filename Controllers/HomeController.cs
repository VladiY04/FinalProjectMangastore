using FinalProject.DataModels;
using FinalProject.Models;
using FinalProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMangaService mangaService;

        public HomeController(IMangaService mangaService)
        {
            this.mangaService = mangaService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CatalogPage(int currentPage = 1)
        {
            var skip = (currentPage - 1) * 3;
            var take = 3;

            var manga = this.mangaService.GetAll(skip, take);
            var totalMangaCount = this.mangaService.GetMangaCount();

            var totalPages = totalMangaCount / 3;
            if (totalMangaCount % 3 > 0)
            {
                totalPages++;
            }

            var model = new MangaModelViewList
            {
                List = GetMangaViewModel(manga),
                CurrentPage = currentPage,
                TotalPages = totalPages,
            };
            return View(model);
        }

        public IActionResult Delete(int mangaId)
        {
            this.mangaService.Delete(mangaId);
            return Ok();
        }

        public IActionResult EditManga(MangaViewModel manga)
        {
            this.mangaService.Update(GetMangaDataModel(manga));
            return RedirectToAction("CatalogPage");
        }

        public IActionResult MangaDetails(int mangaId)
        {
            var mangaDataModel = this.mangaService.GetById(mangaId);


            return View(GetMangaViewModel(mangaDataModel));
        }

        [HttpGet]
        public IActionResult AddManga()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddManga(MangaViewModel manga)
        {
            this.mangaService.Add(GetMangaDataModel(manga));
            return RedirectToAction("CatalogPage");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Authors()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private Manga GetMangaDataModel(MangaViewModel manga)
        {
            return new Manga
            {
                Id=manga.Id,
                Title = manga.Title,
                Author = manga.Author,
                Genre = manga.Genre,
                Description = manga.Description,
                Price = manga.Price,
                PictureUrl = manga.PictureUrl,
                ReleaseDate = manga.ReleaseDate
            };
        }

        private MangaViewModel GetMangaViewModel(Manga m)
        {
            return new MangaViewModel
            {
                Id = m.Id,
                Title = m.Title,
                Author = m.Author,
                Genre = m.Genre,
                Description = m.Description,
                Price = m.Price,
                PictureUrl = m.PictureUrl,
                ReleaseDate = m.ReleaseDate

            };
        }
        private List<MangaViewModel> GetMangaViewModel(List<Manga> source)
        {
            var manga = new List<MangaViewModel>();

            foreach (var m in source)
            {
                manga.Add(GetMangaViewModel(m)); 
            }

            return manga;
        }
    }
}
