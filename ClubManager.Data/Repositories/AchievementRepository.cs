using ClubManager.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using UtilityLibrary;

namespace ClubManager.Data.Repositories
{
    public interface IAchievementRepository : IGenericRepository<Achievement, int>
    {
    }

    public class AchievementRepository : GenericRepository<Achievement, ClubManagerDbContext, int>, IAchievementRepository
    {
        public AchievementRepository(ClubManagerDbContext context) : base(context)
        {
        }
    }
}
