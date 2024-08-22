using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDFZeroTwo.Entidades
{
    public class Alumno
    {
        public int Carne { get; set; }
        public string Nombre_1 { get; set;}
        public string Nombre_2 { get; set; }
        public string Apellido_1 { get; set; }
        public string Apellido_2 { get; set; }

        public DateTime Fecha_Nacimiento { get; set; }

    }
}