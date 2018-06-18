using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models.Dto
{
    public class EstadoDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public object Pais { get; set; }
        public int PaisId { get; set; }
    }
}