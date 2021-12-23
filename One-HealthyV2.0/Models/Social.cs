using System;
using System.ComponentModel.DataAnnotations;

namespace One_HealthyV2._0.Models
{
    public class Social
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(30)]
        public string Name { get; set; }


        [MaxLength(50)]
        public string Icon { get; set; }


        [MaxLength(250)]
        public string Link { get; set; }
    }
}
