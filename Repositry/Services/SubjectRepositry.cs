using university.Repositry.Contract;
using university.Controllers;
using System;
using System.Collections.Generic;
using Course.Data.Repositories;


namespace university.Repositry.Services
{
    public class SubjectRepositry<T> : BaseRepository<T>, ISubjectRepositry<T>
    {
        
    }
}