﻿using Gepa.Entities.ClassPlans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.ClassPlans
{
    public interface ILessonsContentDAO
    {
        void InsertLessonsContent(LessonContentVO newLessonsContent);
        void UpdateLessonsContent(LessonContentVO lessonsContent);
        void DeleteLessonsContent(LessonContentVO lessonsContent);
        LessonContentVO FindLessonsContent(long lessonsContentId);
    }
}
