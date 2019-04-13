using System;
using System.Collections.Generic;
using System.Text;
using UtilityLibrary;

namespace ClubManager.Data.Entity
{
    public class Article : BaseEntity<int>, ISoftDeletable
    {
        public string IdentificationName { get; set; }
        public bool Active { get; set; } = false;
        public bool Navbar { get; set; } = false;

        private ICollection<ArticleLang> articleLangs;
        public virtual ICollection<ArticleLang> ArticleLangs
        {
            get { return articleLangs ?? (articleLangs = new HashSet<ArticleLang>()); }
            set { articleLangs = value; }
        }

        private ICollection<Image> images;
        public virtual ICollection<Image> Images
        {
            get { return images ?? (images = new HashSet<Image>()); }
            set { images = value; }
        }
    }
}
