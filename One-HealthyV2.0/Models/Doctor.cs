using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One_HealthyV2._0.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(30)]
        public string Surname { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [MaxLength(15)]
        public string Phone { get; set; }

        [ForeignKey("Specialty")]
        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
