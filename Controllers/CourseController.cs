using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net;
using university.Repositry.Contract;


namespace university.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CourseController : ControllerBase
    {
        ICourseRepositry<Courses> courseRepo;

        public CourseController(ICourseRepositry<Courses> courseRepo)                       
        {
            this.courseRepo = courseRepo;
        }
        
        //Get all list of course
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Courses> Get()
        {
            return courseRepo.Get();
        }

        public ActionResult<Courses> GetById(int CourseId)
        {
            var course = courseRepo.Get().Where(s => s.CourseId == CourseId);
            if (course == null)
                return NotFound();

            return Ok(course);
        }

        //Get courses by name
        [HttpGet]
        public IEnumerable<Courses> GetByCourseName(string courseName)
        {
            return courseRepo.Get().Where(s => s.CourseName.Equals(courseName));
        }


    [HttpPost]
    public ActionResult Add([FromBody]Courses Coursesdata)
    {
            courseRepo.Add(Coursesdata);
            return Ok();
        
    }


    [HttpPut]
    public ActionResult Update([FromBody]Courses Coursesdata)
    {
       
            courseRepo.Update(Coursesdata.CourseId, Coursesdata ,Coursesdata.CourseName);
            return Ok();
    
    }

     [HttpDelete]
    public ActionResult Delete(int courseID)
    {
            courseRepo.Delete(courseID);
            return Ok();
    }

    [HttpPost]
    public ActionResult AddSubjectsToSemister(int CourseDetailsId, int SubjectId)
    {
            
        courseRepo.AddSubjectsToSemister(CourseDetailsId,SubjectId);
        

        return BadRequest();
    }

    [HttpDelete]
    public ActionResult RemoveSemisterFromCourse(int courseID, int SemisterId)
    {
        
        courseRepo.RemoveSemisterFromCourse(courseID,SemisterId);


        return BadRequest();
    }

    [HttpDelete]
    public ActionResult RemoveSubjectFromSemister(int CourseDetailsId, int subjectId)
    {
        
        courseRepo.RemoveSubjectFromSemister(CourseDetailsId,subjectId);
        
        return BadRequest();
    }

    /*[HttpPut]
    public HttpResponseMessage  UpdateSemistersInCourse([FromBody]Subjects Subjectdata)
    {
        try
        {
            if(Subjectdata != null && Subjectdata.SubjectId > 0)
            {

                foreach ( var subject in databasetables.SubjectsList.Where(w => w.SubjectId == Subjectdata.SubjectId)) 
                {
                    subject.SubjectName = Subjectdata.SubjectName;
                    subject.HasLab = Subjectdata.HasLab;
                    subject.Description = Subjectdata.Description;
                    subject.MinimumPasingMarks = Subjectdata.MinimumPasingMarks;
                }

                return CoursesOk()List;
            }
        }
        catch(Exception ex)
        {
            return BadRequest();
        }

        return BadRequest();
    }*/

    // [HttpPut]
    // public ActionResult UpdateSubjectsInSemisters(int SemisterDetailsId,int CourseDetailsId, int SubjectId)
    // {
    //     try
    //     {
    //         
    //         if(SemisterDetailsId > 0 && CourseDetailsId > 0 && SubjectId > 0)
    //         {

    //             var SemisterDetails = databasetables.SemisterDetailsList.Where(s => s.CourseDetailsId == CourseDetailsId
    //                                                                             && s.SubjectId == SubjectId
    //                                                                             && s.SemisterDetailsId != SemisterDetailsId);

    //             if(SemisterDetails == null)
    //             {
    //                 foreach ( var SemDetails in databasetables.SemisterDetailsList.Where(w => w.SubjectId == SubjectId 
    //                                                                                 && w.SemisterDetailsId == SemisterDetailsId
    //                                                                                 && w.CourseDetailsId == CourseDetailsId)) 
    //                 {
    //                     SemDetails.SemisterDetailsId = SemisterDetailsId;
    //                     SemDetails.CourseDetailsId = CourseDetailsId;
    //                     SemDetails.SubjectId = SubjectId;
    //                 }
    //             }
    //             else{
    //                 return BadRequest();
    //             }

    //             return Ok();
    //         }
    //     }
    //     catch(Exception ex)
    //     {
    //         return BadRequest();
    //     }

    //     return BadRequest();
    // }

    }
}