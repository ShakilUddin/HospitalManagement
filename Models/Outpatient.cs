using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HospitalManagement.Models
{
    class Outpatient
    {
        int id;
        [Key]
        [MaxLength(5)]
        string pid;
        DateTime date;
        string labno;

        public List<Lab> Labs { get; set; }
        public int Id { get => id; set => id = value; }
    }
}
