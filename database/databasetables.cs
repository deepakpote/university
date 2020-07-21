using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace university.Controllers
{
    public class databasetables
    {
        // Courses[] coursesList = new Courses[]
        // {
        //     new Courses {CourseId = 1, CourseName = "BSC", CourseType = "bachelor",NoOfSemister=6, CourseDuration = ""},
        //     new Courses {CourseId = 2, CourseName = "BCA", CourseType = "bachelor",NoOfSemister=6, CourseDuration = ""},
        //     new Courses {CourseId = 3, CourseName = "BCOM", CourseType = "bachelor",NoOfSemister=6, CourseDuration = ""},
        //     new Courses {CourseId = 4, CourseName = "BA", CourseType = "bachelor",NoOfSemister=6, CourseDuration = ""},
        //     new Courses {CourseId = 5, CourseName = "MSC", CourseType = "master ",NoOfSemister=4, CourseDuration = ""},
        //     new Courses {CourseId = 6, CourseName = "MA", CourseType = "master ",NoOfSemister=4, CourseDuration = ""}
   
        // };
        
         public static List<Courses> coursesList = new List<Courses>
        {
            new Courses {CourseId = 1, CourseName = "BSC", CourseType = "bachelor",NoOfSemister=6, CourseDuration = ""},
            new Courses {CourseId = 2, CourseName = "BCA", CourseType = "bachelor",NoOfSemister=6, CourseDuration = ""},
            new Courses {CourseId = 3, CourseName = "BCOM", CourseType = "bachelor",NoOfSemister=6, CourseDuration = ""},
            new Courses {CourseId = 4, CourseName = "BA", CourseType = "bachelor",NoOfSemister=6, CourseDuration = ""},
            new Courses {CourseId = 5, CourseName = "MSC", CourseType = "master ",NoOfSemister=4, CourseDuration = ""},
            new Courses {CourseId = 6, CourseName = "MA", CourseType = "master ",NoOfSemister=4, CourseDuration = ""}
        };

        public static List<Semister> semisterList = new List<Semister>
        {
            new Semister {SemisterId = 1, SemisterName ="one", SemisterDescription=""},
            new Semister {SemisterId = 2, SemisterName ="two", SemisterDescription=""},
            new Semister {SemisterId = 3, SemisterName ="three", SemisterDescription=""},
            new Semister {SemisterId = 4, SemisterName ="four", SemisterDescription=""},
            new Semister {SemisterId = 5, SemisterName ="five", SemisterDescription=""},
            new Semister {SemisterId = 6, SemisterName ="six", SemisterDescription=""},
            new Semister {SemisterId = 7, SemisterName ="sevan", SemisterDescription=""},
            new Semister {SemisterId = 8, SemisterName ="eight", SemisterDescription=""},
        } ;

        public static List<Subjects> SubjectsList = new List<Subjects>
        {
            new Subjects {SubjectId = 1, SubjectName ="Maths", Description="", MinimumPasingMarks=35, HasLab = true},
            new Subjects {SubjectId = 2, SubjectName ="Physics", Description="", MinimumPasingMarks=35, HasLab = true},
            new Subjects {SubjectId = 3, SubjectName ="Mechanics", Description="", MinimumPasingMarks=35, HasLab = true},
            new Subjects {SubjectId = 4, SubjectName ="Electrical", Description="", MinimumPasingMarks=35, HasLab = true},
            new Subjects {SubjectId = 5, SubjectName ="Workshop", Description="", MinimumPasingMarks=35, HasLab = false},
            new Subjects {SubjectId = 6, SubjectName ="Ethics", Description="", MinimumPasingMarks=35, HasLab = false},
        } ;

        //CourseDetails
        public static List<CourseDetails> courseDetailsList = new List<CourseDetails>
        {                                               //BA            //1
            new CourseDetails {CourseDetailsId = 1, CourseId = 1, SemisterId = 1},
            new CourseDetails {CourseDetailsId = 2, CourseId = 1, SemisterId = 2},
            new CourseDetails {CourseDetailsId = 3, CourseId = 1, SemisterId = 3},
            new CourseDetails {CourseDetailsId = 4, CourseId = 2, SemisterId = 1},
            new CourseDetails {CourseDetailsId = 5, CourseId = 2, SemisterId = 2},
            new CourseDetails {CourseDetailsId = 6, CourseId = 2, SemisterId = 3},
        } ;

        public static List<SemisterDetails> SemisterDetailsList = new List<SemisterDetails>
        {
            new SemisterDetails {SemisterDetailsId = 1, CourseDetailsId = 1, SubjectId = 1},
            new SemisterDetails {SemisterDetailsId = 2 ,CourseDetailsId = 1, SubjectId = 2},
            new SemisterDetails {SemisterDetailsId = 3, CourseDetailsId = 1, SubjectId = 3},
            new SemisterDetails {SemisterDetailsId = 4, CourseDetailsId = 2, SubjectId = 1},
            new SemisterDetails {SemisterDetailsId = 5, CourseDetailsId = 2, SubjectId = 2},
            new SemisterDetails {SemisterDetailsId = 6, CourseDetailsId = 3, SubjectId = 2},
        } ;
    }
}