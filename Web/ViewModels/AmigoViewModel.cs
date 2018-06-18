using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Api.Models;

namespace Web.ViewModels
{
    public class AmigoViewModel
    {
        public Amigo Amigo { get; set; }



        public string Title
        {
            get
            {
                return Amigo.Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

//        public AmigoViewModel()
//        {
//            Amigo.Id = 0;
//        }
    }


}