using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using UtilityLibrary;

namespace ClubManager.Data.Entity
{
    public class ArticleLang : BaseEntity<int>, ISoftDeletable
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        [Required]
        public string Lang { get; set; }

        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }

        private ICollection<Image> images;
        public virtual ICollection<Image> Images
        {
            get { return images ?? (images = new HashSet<Image>()); }
            set { images = value; }
        }

        public virtual IEnumerable<Image> AllImages => Images.Union(Article.Images);
        public virtual Image MainImage => AllImages.FirstOrDefault(x => x.Main);
    }
}
