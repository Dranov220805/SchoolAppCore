using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolAppCore.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        
        [Range(0, 4.00)]
        [Column(TypeName = "decimal(3, 2)")]
        public decimal? Grade { get; set; }
    }
}
