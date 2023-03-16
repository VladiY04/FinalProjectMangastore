using FinalProject.DataModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Services
{
    public interface IMangaService
    {
        List<Manga> GetAll(int skip, int take);

       int GetMangaCount();

        void Add(Manga manga);

        Manga GetById(int id);

        void Update(Manga manga);

        void Delete(int id);
    }
}
