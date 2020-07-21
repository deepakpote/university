using System.ComponentModel.DataAnnotations;

namespace university.Controllers
{
    public class Subjects
    {
        [Required()]
        public int SubjectId { get; set; }  
        [Required()]
        public string SubjectName { get; set; }  
        public string Description { get; set; }  
        [Required()]
        public int MinimumPasingMarks { get; set; }
        public bool  HasLab { get; set; }
    }
}