using FinalProject.DataAccess;
using FinalProject.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.Services
{
    public class MangaService : IMangaService
    {

        private readonly AppDBContext db;

        public MangaService(AppDBContext db)
        {
            this.db = db;
        }

        public void Add(Manga manga)
        {
            this.db.Manga.Add(manga);
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            var mangaToDelete = this.db.Manga.FirstOrDefault(x=>x.Id == id);
            if (mangaToDelete == null) 
            {
                return;
            }
            mangaToDelete.IsDeleted = true;
            this.db.SaveChanges();
        }

        public List<Manga> GetAll(int skip, int take)
        {
            return this.db.Manga
                .Where(x=>x.IsDeleted == false)
                .OrderByDescending(x => x.Id)
                .Skip(skip)
                .Take(take)
                .ToList();
        }

        public Manga GetById(int id)
        {
            return this.db.Manga.FirstOrDefault(x => x.Id == id);
        }

        public int GetMangaCount() => this.db.Manga.Where(x => x.IsDeleted == false).Count();

        public void Update(Manga manga)
        {
            var mangaToUpdate = this.db.Manga.FirstOrDefault(x=>x.Id == manga.Id);
            if (mangaToUpdate == null)
            {
                return;
            }
            mangaToUpdate.Title = manga.Title;
            mangaToUpdate.Author = manga.Author;
            mangaToUpdate.Genre = manga.Genre;
            mangaToUpdate.Description = manga.Description;
            mangaToUpdate.Price = manga.Price;
            mangaToUpdate.PictureUrl = manga.PictureUrl;
            mangaToUpdate.ReleaseDate = manga.ReleaseDate;

            this.db.SaveChanges();
        }
    }
}
