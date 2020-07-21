using university.Repositry.Contract;
using university.Controllers;
using System;
using System.Collections.Generic;
using Course.Data.Repositories;
using System.Linq;

namespace university.Repositry.Services
{
    public class SemisterRepositry<T> : BaseRepository<T>, ISemisterRepositry<T>
    {
       public void AddSemisterToCourse(int courseID, int semisterID)
       {

           var result = databasetables.courseDetailsList.Where(s => s.CourseId == courseID & s.SemisterId == semisterID);
                
                if(result != null)
                {
                    var coursedetailsList = databasetables.courseDetailsList.Last();
                    int new_CourseDetailsId = coursedetailsList.CourseDetailsId + 1;

                    databasetables.courseDetailsList.Add(new CourseDetails() { CourseDetailsId = new_CourseDetailsId, CourseId = courseID, SemisterId = semisterID });
                }
                
        
       }
    }
}