using System.ComponentModel.DataAnnotations;

namespace university.Controllers
{
    public class Courses
    {
        [Required()]
        public int CourseId { get; set; }  
        [Required()]
        [StringLength(100)]
        public string CourseName { get; set; }  
        [Required()]
        public string CourseType { get; set; }  
        //[Required()]
        public string CourseCategory { get; set; } 
        [Required()] 
        [Range(1, 12)]
        public int NoOfSemister { get; set; } 
        //[Required()]
        public string Description { get; set; } 
        //[Required()]
        public string CourseDuration { get; set; }   
        
    }
}