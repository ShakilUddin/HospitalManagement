using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    class DoctorDepartment
    {
        [Key]
        private int doctordepartmentid;
        [MaxLength(20)]
        string departmentname;


        public string Departmentname { get => departmentname; set => departmentname = value; }
        public int Doctordepartmentid { get => doctordepartmentid; set => doctordepartmentid = value; }


        public List<Doctor> Doctors { get; set; }

    }
}
