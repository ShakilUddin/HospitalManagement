using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    class Patient
    {
        [Key]
        int patientid;
        [MaxLength(20)]
        string name;
        int age;
        int weight;
        [MaxLength(10)]
        string gender;
        [MaxLength(50)]
        string address;
        int phoneno;
        [MaxLength(20)]
        string disease;
        string DoctorID;

        
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Weight { get => weight; set => weight = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }
        public int Phoneno { get => phoneno; set => phoneno = value; }
        public string Disease { get => disease; set => disease = value; }       
        public string DoctorID1 { get => DoctorID; set => DoctorID = value; }

        public List<Doctor> Doctors { get; set; }
        public int Patientid { get => patientid; set => patientid = value; }

        public Inpatient Inpatient { get; set; }

        public Outpatient Outpatient { get; set; }
    }
}
