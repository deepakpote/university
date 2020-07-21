using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net;

namespace university.Controllers
{
    public interface ICourse
    {
        IEnumerable<Courses> Get();

        IEnumerable<Courses> GetByCourseName(string courseName);

        HttpResponseMessage  Add([FromBody]Courses Coursesdata);

        HttpResponseMessage  Update([FromBody]Courses Coursesdata);

        public HttpResponseMessage Delete(int courseID);

    }
}