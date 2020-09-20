using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    class Lab
    {
        int id;
        [Key]
        [MaxLength(5)]
        string labno;
        int PatientId;
        int weight;
        string doctorid;
        [MaxLength(15)]
        string category;
        [MaxLength(15)]
        string patient_type;
        int amount;

        public string Labno { get => labno; set => labno = value; }
        public int PatientId1 { get => PatientId; set => PatientId = value; }
        public int Weight { get => weight; set => weight = value; }
        public string Doctorid { get => doctorid; set => doctorid = value; }
        public DateTime Date { get; set; }
        public string Category { get => category; set => category = value; }
        public string Patient_type { get => patient_type; set => patient_type = value; }
        public int Amount { get => amount; set => amount = value; }

        public List<Doctor> Doctors { get; set; }

        public Inpatient Inpatient { get; set; }

        public Outpatient Outpatient { get; set; }
        public int Id { get => id; set => id = value; }
    }
}