using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One_HealthyV2._0.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(30)]
        public string FullName { get; set; }


        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(15)]
        public string Phone { get; set; }

        public DateTime Date { get; set; }

        [ForeignKey("Specialty")]
        public int SpecialityId { get; set; }
        public Specialty Specialty { get; set; }
    }
}
