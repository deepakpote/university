using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net;
using university.Repositry.Contract;
using university.ICourse;


namespace university.Controllers
{
     [ApiController]
    [Route("[controller]/[action]")]
    public class SubjectController : ControllerBase
    {

        ISubjectRepositry<Subjects> subjectRepo;

        public SubjectController(ISubjectRepositry<Subjects> subjectRepo)
        {
            this.subjectRepo = subjectRepo;
        }
    
    //Get all list of subjects
    [HttpGet]
    [Route("GetAll")]
    public IEnumerable<Subjects> Get()
    {
        return subjectRepo.Get();
    }

    public ActionResult<Subjects> GetById(int SubjectId)
        {
            var sub = subjectRepo.Get().Where(s => s.SubjectId == SubjectId);
            if (sub == null)
                return NotFound();

            return Ok(sub);
        }

    [HttpGet]
    public ActionResult<Subjects> GetByName(string SubjectName)
    {
        var name = subjectRepo.Get().Where(s => s.SubjectName.Equals(SubjectName));
        if (name == null)
                return NotFound();

            return Ok(name);
    }
    
    
    [HttpPost]
    public ActionResult Add([FromBody]Subjects Subjectdata)
    {
      
            subjectRepo.Add(Subjectdata);
            return Ok();
      
    }

    [HttpPut]
    public ActionResult Update([FromBody]Subjects Subjectdata)
    {
        
            subjectRepo.Update(Subjectdata.SubjectId, Subjectdata, Subjectdata.SubjectName);
            return Ok();
      
    }

      [HttpDelete]
    public ActionResult Delete(int subjectID)
    {
            var itemToRemove = GetById(subjectID);

                if (itemToRemove == null)
                {
                    return NotFound();
                }

                subjectRepo.Delete(subjectID);
                return Ok();
        
    }

    }
}