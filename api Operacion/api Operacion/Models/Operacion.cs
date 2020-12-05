using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace api_Operacion.Models
{
    public class Operacion
    {
        [Key]
        [Required]
        public int Numero { get; set; }

    }
}