using System;
using System.Collections.Generic;
using System.Text;
using UtilityLibrary;

namespace ClubManager.Data.Entity
{
    public class AchievementLang : BaseEntity<int>, ISoftDeletable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Lang { get; set; }

        public int AchievementId { get; set; }
        public virtual Achievement Achievement { get; set; }
    }
}
