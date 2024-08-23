using System.Data.Linq.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba02.PDF
{
    public class Alumnos
    {
        [Table(Name = "Alumno")]
        public class Alumno
        {
            [Column(IsPrimaryKey = true)]
            public int Carne { get; set; }

            [Column]
            public string Nombre1 { get; set; }

            [Column]
            public string Nombre2 { get; set; }

            [Column]
            public string Apellido1 { get; set; }

            [Column]
            public string Apellido2 { get; set; }

            [Column]
            public DateTime Fecha_Nac { get; set; }

            [Column]
            public string Celular { get; set; }

            
            [Column]
            public string email { get; set; }

            [Column]
            public Boolean estado { get; set; }
            
        }

    }
}