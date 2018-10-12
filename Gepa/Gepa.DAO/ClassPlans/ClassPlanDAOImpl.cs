using Gepa.Entities.Framework;
using Gepa.Entities.Framework.Entities.ClassPlans;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Gepa.DAO.ClassPlans
{
    public class ClassPlanDAOImpl : AbstractDAO, IClassPlanDAO
    {
        public ClassPlanDAOImpl() : base()
        {
        }

        public void DeleteClassPlan(ClassPlan classPlan)
        {
            using (EntityModel em = new EntityModel())
            {
                em.ClassPlan.Attach(classPlan);
                em.ClassPlan.Remove(classPlan);
                em.SaveChanges();
            }
        }

        public List<ClassPlan> FindAllClassPlans()
        {
            List<ClassPlan> classPlans = new List<ClassPlan>();

            using (EntityModel em = new EntityModel())
            {
                classPlans = em.ClassPlan.ToList();
            }

            return classPlans;
        }

        public ClassPlan FindClassPlan(long classPlanId)
        {
            ClassPlan classPlan = null;
            using (EntityModel em = new EntityModel())
            {
                classPlan = em.ClassPlan
                     .Where(c => c.ClassPlanId == classPlanId)
                     .Include(c => c.Chores)
                     .Include(c => c.ClassGoals)
                     .Include(c => c.Evaluetions)
                     .Include(c => c.LessonsContents)
                     .FirstOrDefault();
            }
            return classPlan;
        }

        public async Task<ClassPlan> FindClassPlanAsync(long classPlanId)
        {
            ClassPlan classPlan = null;
            using (EntityModel em = new EntityModel())
            {
                classPlan = await em.ClassPlan
                     .Where(c => c.ClassPlanId == classPlanId)
                     .Include(c => c.Chores)
                     .Include(c => c.ClassGoals)
                     .Include(c => c.Evaluetions)
                     .Include(c => c.LessonsContents)
                     .FirstOrDefaultAsync();
            }
            return classPlan;
        }

        public void InsertClassPlan(ClassPlan newClassPlan)
        {
            if (newClassPlan.TeacherId > 0)
            {
                using (EntityModel em = new EntityModel())
                {
                    var teacher = em.Teacher
                    .Where(z => z.TeacherId == newClassPlan.TeacherId)
                    .Include(t => t.ClassPlan)
                    .FirstOrDefault();
                    if (teacher != null)
                    {
                        teacher.ClassPlan.Add(newClassPlan);
                        em.SaveChanges();
                    }
                    else
                    {
                        throw new System.Exception(string.Format("ID de professor ({0}) não salvo na base de dados!", newClassPlan.TeacherId));
                    }

                }
            }
            else
            {
                throw new System.Exception(string.Format("ID de professor ({0}) inválido!", newClassPlan.TeacherId));
            }

        }

        public async Task InsertClassPlanAsync(ClassPlan newClassPlan)
        {
            if (newClassPlan.TeacherId > 0)
            {
                using (EntityModel em = new EntityModel())
                {
                    var teacher = await em.Teacher
                    .Where(z => z.TeacherId == newClassPlan.TeacherId)
                    .Include(t => t.ClassPlan)
                    .FirstOrDefaultAsync();
                    if (teacher != null)
                    {
                        teacher.ClassPlan.Add(newClassPlan);
                        await em.SaveChangesAsync();
                    }
                    else
                    {
                        throw new System.Exception(string.Format("ID de professor ({0}) não salvo na base de dados!", newClassPlan.TeacherId));
                    }

                }
            }
            else
            {
                throw new System.Exception(string.Format("ID de professor ({0}) inválido!", newClassPlan.TeacherId));
            }
        }

        public void UpdateClassPlan(ClassPlan classPlan)
        {
            using (EntityModel em = new EntityModel())
            {
                var current = em.ClassPlan
                     .Where(c => c.ClassPlanId == classPlan.ClassPlanId)
                     .Include(c => c.Chores)
                     .Include(c => c.ClassGoals)
                     .Include(c => c.Evaluetions)
                     .Include(c => c.LessonsContents)
                     .FirstOrDefault();
                if (current == null)
                {
                    return;
                }

                current.Chores.RemoveAll(c => classPlan.Chores.Exists(ch => ch.ChoresId == c.ChoresId) == false);
                current.ClassGoals.RemoveAll(c => classPlan.ClassGoals.Exists(ch => ch.ClassGoalsId == c.ClassGoalsId) == false);
                current.Evaluetions.RemoveAll(c => classPlan.Evaluetions.Exists(ch => ch.EvaluetionId == c.EvaluetionId) == false);
                current.LessonsContents.RemoveAll(c => classPlan.LessonsContents.Exists(ch => ch.LessonsContentId == c.LessonsContentId) == false);

                foreach (var chore in classPlan.Chores)
                {
                    var currentChore = current.Chores.FirstOrDefault(c => c.ChoresId == chore.ChoresId);
                    if (currentChore == null)
                        current.Chores.Add(chore);
                    else
                        em.Entry(currentChore).CurrentValues.SetValues(chore);
                }

                foreach (var classGoals in classPlan.ClassGoals)
                {
                    var currentClassGoals = current.ClassGoals.FirstOrDefault(c => c.ClassGoalsId == classGoals.ClassGoalsId);
                    if (currentClassGoals == null)
                        current.ClassGoals.Add(classGoals);
                    else
                        em.Entry(currentClassGoals).CurrentValues.SetValues(classGoals);
                }

                foreach (var evaluations in classPlan.Evaluetions)
                {
                    var currentEvaluation = current.Evaluetions.FirstOrDefault(c => c.EvaluetionId == evaluations.EvaluetionId);
                    if (currentEvaluation == null)
                        current.Evaluetions.Add(evaluations);
                    else
                        em.Entry(currentEvaluation).CurrentValues.SetValues(evaluations);
                }

                foreach (var lessonsContent in classPlan.LessonsContents)
                {
                    var currentLessonContent = current.LessonsContents.FirstOrDefault(c => c.LessonsContentId == lessonsContent.LessonsContentId);
                    if (currentLessonContent == null)
                        current.LessonsContents.Add(lessonsContent);
                    else
                        em.Entry(currentLessonContent).CurrentValues.SetValues(lessonsContent);
                }

                em.Entry(current).CurrentValues.SetValues(classPlan);
                em.SaveChanges();
            }
        }

        public async Task<List<ClassPlan>> FindAllTeacherClassPlans(long teacherId, bool loadAllData = false)
        {
            using (EntityModel em = new EntityModel())
            {
                if (loadAllData)
                    return await em.ClassPlan
                         .Where(c => c.TeacherId == teacherId)
                         .Include(c => c.Chores)
                         .Include(c => c.ClassGoals)
                         .Include(c => c.Evaluetions)
                         .Include(c => c.LessonsContents)
                         .ToListAsync();
                else
                    return await em.ClassPlan
                        .Where(c => c.TeacherId == teacherId)
                        .ToListAsync();
            }
        }
    }
}
