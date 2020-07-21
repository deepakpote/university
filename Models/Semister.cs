using System.ComponentModel.DataAnnotations;

namespace university.Controllers
{
    public class Semister
    {
        [Required()]
        public int SemisterId { get; set; } 
        [Required()] 
        [StringLength(100)]
        public string SemisterName { get; set; }  
        public string SemisterDescription { get; set; }  
    }
}

