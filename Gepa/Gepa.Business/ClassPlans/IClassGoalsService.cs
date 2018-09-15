﻿using Gepa.Entities.Framework.Entities.ClassPlans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Business.ClassPlans
{
    public interface IClassGoalsService : IGepaService
    {
        void InsertClassGoals(ClassGoals newClassGoals);
        void UpdateClassGoals(ClassGoals classGoals);
        void DeleteClassGoals(ClassGoals classGoals);
        ClassGoals FindClassGoals(long classGoalsId);
        Task<ClassGoals> FindClassGoalsAsync(long classGoalsId);
    }
}
