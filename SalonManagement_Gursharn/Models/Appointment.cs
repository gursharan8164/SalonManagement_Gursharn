using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalonManagement_Gursharn.Models
{
    public class Appointment
    {
        public int ID { get; set; }
        public int StaffID { get; set; }
        public int CustomerID { get; set; }
        public Staff Staff { get; set; }
        public Customer Customer { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public Nullable<DateTime> AppointmentDate { get; set; }
        public decimal Charges { get; set; }
    }
}
