using System.ComponentModel.DataAnnotations;

namespace Netcode.Models
{
    public class Faculty
    {
        [Key]
        public string FacultyID { get; set; }
        public string FacultyName { get; set; }
    }
}