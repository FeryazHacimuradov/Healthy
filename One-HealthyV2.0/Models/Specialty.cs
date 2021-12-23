using System;
using System.ComponentModel.DataAnnotations;

namespace One_HealthyV2._0.Models
{
    public class Specialty
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
    }
}
