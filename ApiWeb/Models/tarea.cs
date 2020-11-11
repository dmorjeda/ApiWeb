using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeb.Models
{
    public class Tarea
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public bool Completa { get; set; }

    }
}
