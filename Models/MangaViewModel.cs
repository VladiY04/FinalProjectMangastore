using System;

namespace FinalProject.Models
{
    public class MangaViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string PictureUrl { get; set; }

        public DateTime ReleaseDate { get; set; }


    }
}
