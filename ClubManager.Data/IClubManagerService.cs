using ClubManager.Data.Entity;
using ClubManager.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using UtilityLibrary;

namespace ClubManager.Data
{
    public interface IClubManagerService
    {
        IAchievementRepository Achievements { get; set; }
        IHttpContextAccessor Context { get; set; }
        UserManager<IdentityUser> UserManager { get; set; }

        ResultSvc<Achievement> CreateAchievement(string name, string description, string lang, int reward, int? count);

        void Dispose();
        void Commit();
    }
}
