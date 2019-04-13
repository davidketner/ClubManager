using System;
using System.Collections.Generic;
using System.Text;
using UtilityLibrary;

namespace ClubManager.Data.Entity
{
    public class AchievementLevel : BaseEntity<int>, ISoftDeletable
    {
        public int? Count { get; set; }
        public int Reward { get; set; }

        public int AchievementId { get; set; }
        public virtual Achievement Achievement { get; set; }
    }
}
