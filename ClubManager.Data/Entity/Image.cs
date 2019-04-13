using System;
using System.Collections.Generic;
using System.Text;
using UtilityLibrary;

namespace ClubManager.Data.Entity
{
    public class Image : BaseEntity<int>, ISoftDeletable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Main { get; set; }

        public int? ArticleId { get; set; }
        public virtual Article Article { get; set; }

        public int? ArticleLangId { get; set; }
        public virtual ArticleLang ArticleLang { get; set; }
    }
}
