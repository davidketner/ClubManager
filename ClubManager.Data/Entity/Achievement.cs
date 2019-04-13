using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UtilityLibrary;

namespace ClubManager.Data.Entity
{
    public class Achievement : BaseEntity<int>, ISoftDeletable
    {
        public virtual string DefaultName => AchievementLangs.FirstOrDefault(x => x.Lang == "en")?.Name;
        public virtual string Name => AchievementLangs.FirstOrDefault(x => x.Lang == System.Globalization.CultureInfo.CurrentCulture.Name)?.Name;

        public virtual string DefaultDescription => AchievementLangs.FirstOrDefault(x => x.Lang == "en")?.Description;
        public virtual string Description => AchievementLangs.FirstOrDefault(x => x.Lang == System.Globalization.CultureInfo.CurrentCulture.Name)?.Description;

        private ICollection<AchievementLevel> achievementLevels;
        public virtual ICollection<AchievementLevel> AchievementLevels
        {
            get { return achievementLevels ?? (achievementLevels = new HashSet<AchievementLevel>()); }
            set { achievementLevels = value; }
        }

        private ICollection<AchievementLang> achievementLangs;
        public virtual ICollection<AchievementLang> AchievementLangs
        {
            get { return achievementLangs ?? (achievementLangs = new HashSet<AchievementLang>()); }
            set { achievementLangs = value; }
        }
    }
}
