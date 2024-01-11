using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Models
{
    [Table("students", Schema = "public")]
    public class Student
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int student_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime date_of_birth { get; set; }
        public string address { get; set; }
    }
}
