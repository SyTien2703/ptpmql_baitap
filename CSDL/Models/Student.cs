
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CSDL.Models;

    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public required string FullName { get; set; }
    }