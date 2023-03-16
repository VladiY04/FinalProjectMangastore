using System.Collections.Generic;

namespace FinalProject.Models
{
    public class MangaModelViewList
    {
        public List<MangaViewModel> List { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }
    }
}
