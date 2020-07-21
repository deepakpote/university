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
    public class SemisterController :  ControllerBase
    {

        ISemisterRepositry<Semister> semisterRepo;

        public SemisterController(ISemisterRepositry<Semister> semisterRepo)
        {
            this.semisterRepo = semisterRepo;
        }

        [HttpGet]
        public IEnumerable<Semister> Get()
        {
            return semisterRepo.Get();
        }

         [HttpPost]
        public ActionResult Add([FromBody]Semister Semisterdata)
        {
            
                semisterRepo.Add(Semisterdata);
                return Ok();

        }

    [HttpPut]
    public ActionResult Update([FromBody]Semister Semisterdata)
    {

            semisterRepo.Update(Semisterdata.SemisterId, Semisterdata ,Semisterdata.SemisterName);
            return Ok();
  

    }

    [HttpPost]
    public ActionResult AddSemisterToCourse(int courseID, int semisterID)
    {
       semisterRepo.AddSemisterToCourse(courseID,semisterID);
     
        return BadRequest();
    }
        
    }
}