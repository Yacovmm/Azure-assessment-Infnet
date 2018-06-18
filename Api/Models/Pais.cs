using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Api.Models
{
    public class Pais
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public List<Estado> Estados { get; set; }

        
    }
}