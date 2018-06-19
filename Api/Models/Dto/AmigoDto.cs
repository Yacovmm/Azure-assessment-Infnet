using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Api.Models.Dto
{
    public class AmigoDto
    {
        [Key]
        public int Id { get; set; }

        public string Image { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(200)]
        public string Email { get; set; }

        [Required]
        [Range(0, 11)]
        public int Tel { get; set; }

        [Required]
        public DateTime Birthday { get; set; }
    }
}