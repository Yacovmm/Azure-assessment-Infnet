using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models.Dto
{
    public class AmigoDto
    {
        public EstadoDto EstadoDto { get; set; }
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Tel { get; set; }
        public DateTime Birthday { get; set; }
    }
}
