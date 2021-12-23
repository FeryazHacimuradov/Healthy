using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace One_HealthyV2._0.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string UserName { get; set; }
        [MaxLength(250)]
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
