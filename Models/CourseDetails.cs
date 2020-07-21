using System.ComponentModel.DataAnnotations;

namespace university.Controllers
{
    
    public class CourseDetails
    {
        [Required()]
        public int CourseDetailsId { get; set; }  
        [Required()]
        public int CourseId { get; set; }  
        [Required()]
        public int SemisterId { get; set; } 

    }

     public class SemisterDetails
    {
        [Required()]

        public int SemisterDetailsId { get; set; }  
        [Required()]
        public int CourseDetailsId { get; set; }  
        [Required()]
        public int SubjectId { get; set; }  

    }

    public abstract class Model 
    {

    }
}