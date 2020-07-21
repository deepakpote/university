using university.Repositry.Contract;
using university.Controllers;
using System;
using System.Collections.Generic;
using Course.Data.Repositories;
using System.Linq;

namespace university.Repositry.Services
{
    public class CourseRepositry<T> : BaseRepository<T>, ICourseRepositry<T>
    {

         public void AddSubjectsToSemister(int CourseDetailsId, int SubjectId)
        {

                var result = databasetables.SemisterDetailsList.Where(s => s.CourseDetailsId == CourseDetailsId & s.SubjectId == SubjectId);
                
                if(result != null)
                {
                    var semisterdetailsList = databasetables.SemisterDetailsList.Last();
                    int new_SemisterDetailsId = semisterdetailsList.SemisterDetailsId + 1;

                    databasetables.SemisterDetailsList.Add(new SemisterDetails() {SemisterDetailsId = new_SemisterDetailsId, CourseDetailsId = CourseDetailsId, SubjectId = SubjectId });
                }
        }

    public void RemoveSemisterFromCourse(int courseID, int SemisterId)
    {
       
            if(courseID > 0 && SemisterId > 0)
            {

                var itemToRemove = databasetables.courseDetailsList.Single(r => r.CourseId == courseID && r.SemisterId == SemisterId);
                databasetables.courseDetailsList.Remove(itemToRemove);
            }
    }


    public void RemoveSubjectFromSemister(int CourseDetailsId, int subjectId)
    {
            if(CourseDetailsId > 0 && subjectId > 0)
            {
                var itemToRemove = databasetables.SemisterDetailsList.Single(r => r.CourseDetailsId == CourseDetailsId && r.SubjectId == subjectId);
                databasetables.SemisterDetailsList.Remove(itemToRemove);
            }
    }
    }
}