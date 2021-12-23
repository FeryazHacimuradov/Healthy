using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One_HealthyV2._0.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50)]
        public string FullName { get; set; }


        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(500)]
        public string Address { get; set; }

        [MaxLength(500)]
        public string Subject { get; set; }

        [Column(TypeName = "ntext")]
        public string Text { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
