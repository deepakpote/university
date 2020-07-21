using university.Controllers;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net;

namespace university.ICourse
{
    public interface ISemister
    {
         IEnumerable<Semister> ListAllSemister();

         HttpResponseMessage  Add([FromBody]Semister Semisterdata);

         HttpResponseMessage  AddSemisterToCourse(int courseID, int semisterID);
         
    }
}