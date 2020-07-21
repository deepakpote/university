using university.Controllers;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace university.ICourse
{
    public interface ISubject
    {
        IEnumerable<Subjects> ListAllSubjects();

        HttpResponseMessage Add([FromBody]Subjects Subjectdata);

        IEnumerable<Subjects> ListSubjectByName(string subjectName);

        HttpResponseMessage  Update([FromBody]Subjects Subjectdata);


         
    }
}