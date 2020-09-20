using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    class Doctor
    {
        int id;
        [Key]
        [MaxLength(5)]
        string doctorid;
        [MaxLength(15)]
        string doctorname;
        [MaxLength(15)]
        string dept;
        int doctordepartmentid;






        public DoctorDepartment DoctorDepartment { get; set; }
        public int Id { get => id; set => id = value; }
        public string Doctorid { get => doctorid; set => doctorid = value; }
        public string Doctorname { get => doctorname; set => doctorname = value; }
        public string Dept { get => dept; set => dept = value; }
        public int Doctordepartmentid { get => doctordepartmentid; set => doctordepartmentid = value; }
    }
}
