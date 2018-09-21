using AutoMapper;
using Gepa.Entities.Framework.Entities.Users;
using Gepa.Identity.Base.Model;
using Gepa.Identity.Base.StartConfig;
using Gepa.Site.Models.Account;
using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;
using System.Web;

namespace Gepa.Site.Mappers
{
    public class AutoMapperConfig
    {
        public static void ConfigureMappings()
        {
            Mapper.Initialize(mapper =>
            {
                mapper.CreateMap<Teacher, TeacherEditModel>()
                .AfterMap(async (src, dest) => 
                {
                    var user = await GetUser(src.UserId);
                    dest.UserName = user.UserName;
                });
            });
        }

        private static async Task<ApplicationUser> GetUser(string userId)
        {
            var userService = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            return await userService.FindByIdAsync(userId);
        }
    }
}