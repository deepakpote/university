using System;
using System.Collections.Generic;
using university.Controllers;

namespace university.Repositry.Contract
{
    public interface IBaseRepositry<T>
    {
         List<T> Get(); 

         void Add  (T obj);

         void Update(int id,T obj, string name);

         void Delete(int id);

    }

    public interface ICourseRepositry<T> : IBaseRepositry<T>
    {
        void AddSubjectsToSemister(int CourseDetailsId, int SubjectId);
        void RemoveSemisterFromCourse(int courseID, int SemisterId);
        void RemoveSubjectFromSemister(int CourseDetailsId, int subjectId);
    }

    public interface ISemisterRepositry<T> : IBaseRepositry<T>
    {
        void AddSemisterToCourse(int courseID, int semisterID);
    }
    public interface ISubjectRepositry<T> : IBaseRepositry<T>
    {
        
    }

}