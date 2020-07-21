using university.Repositry.Contract;
using university.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Course.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepositry<T>
    {
        public void Add(T entity)
        {
            Type type = typeof(T);

            if (type == typeof(Courses))
            {
                 databasetables.coursesList.Add(entity as Courses);
            }
            else if (type == typeof(Semister))
            {
                 databasetables.semisterList.Add(entity as Semister);
            }
            else if (type == typeof(Subjects))
            {
                databasetables.SubjectsList.Add(entity as Subjects);
            }
        }

        public void Delete(int id)
        {

            Type type = typeof(T);

            if (type == typeof(Courses))
            {
                databasetables.coursesList.RemoveAll(x=>x.CourseId==id);
            }
            else if (type == typeof(Semister))
            {
                databasetables.semisterList.RemoveAll(x => x.SemisterId == id);
            }
            else if (type == typeof(Subjects))
            {
                databasetables.SubjectsList.RemoveAll(x => x.SubjectId == id);
            }
        }

        public List<T> Get()
        {
            Type type = typeof(T);

            if (type == typeof(Courses))
            {
                return databasetables.coursesList as List<T>;
            }
            else if (type == typeof(Semister))
            {
                return databasetables.semisterList as List<T>;
            }
            else if(type == typeof(Subjects))
            {
                return databasetables.SubjectsList as List<T>;
            }
            return null;
        }

        public void Update(int id, T entity, string Name)
        {
            Type type = typeof(T);

            if (type == typeof(Courses))
            {
              foreach ( var course in databasetables.coursesList.Where(w => w.CourseId == id)) 
                {
                    course.CourseName = Name;
                }
                   
            }
            else if (type == typeof(Semister))
            {
                foreach ( var sem in databasetables.semisterList.Where(w => w.SemisterId == id)) 
                {
                    sem.SemisterName = Name;
                }
            }
            else if (type == typeof(Subjects))
            {
                foreach ( var sub in databasetables.SubjectsList.Where(w => w.SubjectId == id)) 
                {
                    sub.SubjectName = Name;
                }
            }
        }
    }
}