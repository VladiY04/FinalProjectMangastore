using System;

namespace FinalProject.DataModels
{
    public class Manga
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string PictureUrl { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}
