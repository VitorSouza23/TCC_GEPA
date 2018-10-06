using AutoMapper;
using Gepa.Entities.Framework.Entities.ClassPlans;
using Gepa.Entities.Framework.Entities.Users;
using Gepa.Identity.Base.Model;
using Gepa.Identity.Base.StartConfig;
using Gepa.Site.Models.Account;
using Gepa.Site.Models.ClassPlans;
using Microsoft.AspNet.Identity.Owin;
using System.Collections.Generic;
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

                mapper.CreateMap<ClassPlanModel, ClassPlan>()
                    .AfterMap((src, dest) =>
                    {
                        dest.ClassPlanId = src.Id;
                        dest.LessonsContents = Mapper.Map<List<LessonsContentModel>, List<LessonsContent>>(src.Contents);
                        dest.ClassGoals = Mapper.Map<List<ClassGoalsModel>, List<ClassGoals>>(src.ClassGoals);
                        dest.Chores = Mapper.Map<List<ChoresModel>, List<Chores>>(src.Chores);
                        dest.Evaluetions = Mapper.Map<List<EvaluationModel>, List<Evaluetion>>(src.Evaluations);
                    });

                mapper.CreateMap<ClassPlan, ClassPlanModel>()
                    .AfterMap((src, dest) =>
                    {
                        dest.Id = src.ClassPlanId;
                        dest.Contents = Mapper.Map<List<LessonsContentModel>>(src.LessonsContents);
                        dest.ClassGoals = Mapper.Map<List<ClassGoalsModel>>(src.ClassGoals);
                        dest.Chores = Mapper.Map<List<ChoresModel>>(src.Chores);
                        dest.Evaluations = Mapper.Map<List<EvaluationModel>>(src.Evaluetions);
                    });

                mapper.CreateMap<ChoresModel, Chores>()
                    .AfterMap((src, dest) =>
                    {
                        dest.ChoresId = src.Id;
                        dest.Completed = src.IsCompletedTask;
                    });

                mapper.CreateMap<Chores, ChoresModel>()
                    .AfterMap((src, dest) =>
                    {
                        dest.Id = src.ChoresId;
                        dest.IsCompletedTask = src.Completed;
                    });

                mapper.CreateMap<ClassGoalsModel, ClassGoals>()
                    .AfterMap((src, dest) =>
                    {
                        dest.ClassGoalsId = src.Id;
                    });

                mapper.CreateMap<ClassGoals, ClassGoalsModel>()
                   .AfterMap((src, dest) =>
                   {
                       dest.Id = src.ClassGoalsId;
                   });

                mapper.CreateMap<EvaluationModel, Evaluetion>()
                    .AfterMap((src, dest) =>
                    {
                        dest.EvaluetionId = src.Id;
                        dest.Description = src.EvaluationDescription;
                    });

                mapper.CreateMap<Evaluetion, EvaluationModel>()
                   .AfterMap((src, dest) =>
                   {
                       dest.Id = src.EvaluetionId;
                       dest.EvaluationDescription = src.Description;
                   });

                mapper.CreateMap<LessonsContentModel, LessonsContent>()
                    .AfterMap((src, dest) =>
                    {
                        dest.LessonsContentId = src.Id;
                    });

                mapper.CreateMap<LessonsContent, LessonsContentModel>()
                   .AfterMap((src, dest) =>
                   {
                       dest.Id = src.LessonsContentId;
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