using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class Estado
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Pais Pais { get; set; }

        public int PaisId { get; set; }

    }
}