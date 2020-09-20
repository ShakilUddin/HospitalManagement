using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    class Inpatient
    {
        int id; 
        [Key]
        [MaxLength(5)]
        string pid;
        [MaxLength(50)]
        string room_no;
        DateTime date_of_adm;
        DateTime date_of_dis;
        int advance;
        string labno;

        public string Pid { get => pid; set => pid = value; }
        public string Room_no { get => room_no; set => room_no = value; }
        public DateTime Date_of_adm { get => date_of_adm; set => date_of_adm = value; }
        public DateTime Date_of_dis { get => date_of_dis; set => date_of_dis = value; }
        public int Advance { get => advance; set => advance = value; }
        public string Labno { get => labno; set => labno = value; }

        public List<Lab> Labs { get; set; }
        public int Id { get => id; set => id = value; }
    }
}
