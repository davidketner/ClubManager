using ClubManager.Data.Repositories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.Data
{
    public class ClubManagerEFCoreService : ClubManagerService
    {
        public ClubManagerDbContext DbContext { get; }

        public ClubManagerEFCoreService(ClubManagerDbContext db) : base()
        {
            DbContext = db;
            Achievements = new AchievementRepository(db);
            Context = new HttpContextAccessor();
        }

        public override void Commit()
        {
            DbContext.SaveChanges();
        }

        public override void Dispose()
        {
            DbContext.Dispose();
        }
    }
}
