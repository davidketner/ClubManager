using ClubManager.Data.Entity;
using ClubManager.Data.Extensions;
using ClubManager.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using UtilityLibrary;

namespace ClubManager.Data
{
    public class ClubManagerService : IClubManagerService
    {
        public IAchievementRepository Achievements { get; set; }

        public IHttpContextAccessor Context { get; set; }
        public UserManager<IdentityUser> UserManager { get; set; }

        public ResultSvc<Achievement> CreateAchievement(string name, string description, string lang, int reward, int? count)
        {
            var achievement = new Achievement();
            var result = new ResultSvc<Achievement>(achievement);
            try
            {
                if (!string.IsNullOrEmpty(name))
                {
                    achievement.UserCreatedId = Context.HttpContext.User.GetUserId();
                    achievement.AchievementLangs.Add(new AchievementLang
                    {
                        Name = name?.Trim(),
                        Description = description?.Trim(),
                        Lang = lang,
                        UserCreatedId = Context.HttpContext.User.GetUserId()
                    });
                    achievement.AchievementLevels.Add(new AchievementLevel
                    {
                        Reward = reward,
                        Count = count,
                        UserCreatedId = Context.HttpContext.User.GetUserId()
                    });
                    Achievements.Add(achievement);
                }
                else
                {
                    result.Errors.Add("Název musí být vyplněn!");
                }
            }
            catch
            {
                result.Errors.Add("Něco se pokazilo!");
            }
            return result;
        }

        public virtual void Commit()
        {
            throw new NotImplementedException();
        }

        public virtual void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
