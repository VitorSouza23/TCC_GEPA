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
                classPlan = em.ClassPlan.Single(a => a.ClassPlanId == classPlanId);
            }
            return classPlan;
        }

        public async Task<ClassPlan> FindClassPlanAsync(long classPlanId)
        {
            ClassPlan classPlan = null;
            using (EntityModel em = new EntityModel())
            {
                classPlan = await em.ClassPlan.FindAsync(classPlanId);
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
                em.Entry(classPlan).State = EntityState.Modified;
                em.SaveChanges();
            }
        }
    }
}
