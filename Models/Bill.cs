using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HospitalManagement.Models
{
    class Bill
    {
        int id; 
        [Key]
        [MaxLength(50)]
        string bill_no;
        [MaxLength(5)]
        string pid;
        [MaxLength(10)]
        string patient_type;
        int doctor_charge;
        int medicine_charge;
        int room_charge;
        int oprtn_charge;
        int no_of_days;
        int nursing_charge;
        int advance;
        [MaxLength(50)]
        string health_card;
        int lab_charge;
        int totalbill;

        public string Bill_no { get => bill_no; set => bill_no = value; }
        public string Pid { get => pid; set => pid = value; }
        public string Patient_type { get => patient_type; set => patient_type = value; }
        public int Doctor_charge { get => doctor_charge; set => doctor_charge = value; }
        public int Medicine_charge { get => medicine_charge; set => medicine_charge = value; }
        public int Room_charge { get => room_charge; set => room_charge = value; }
        public int Oprtn_charge { get => oprtn_charge; set => oprtn_charge = value; }
        public int No_of_days { get => no_of_days; set => no_of_days = value; }
        public int Nursing_charge { get => nursing_charge; set => nursing_charge = value; }
        public int Advance { get => advance; set => advance = value; }
        public string Health_card { get => health_card; set => health_card = value; }
        public int Lab_charge { get => lab_charge; set => lab_charge = value; }
        public int Totalbill { get => totalbill; set => totalbill = value; }

        public Patient Patient { get; set; }

        public Inpatient Inpatient { get; set; }

        public Outpatient Outpatient { get; set; }
        public int Id { get => id; set => id = value; }
    }
}
