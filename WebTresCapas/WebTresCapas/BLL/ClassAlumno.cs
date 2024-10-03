using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebTresCapas.DAL.DataSetGeneralTableAdapters;

namespace WebTresCapas.BLL
{
    public class ClassAlumno
    {
        //Atributos
        private alumnoTableAdapter alumno = new alumnoTableAdapter();

        //Propiedades
        private alumnoTableAdapter ALUMNO
        {
            get
            {
                if(alumno == null)
                    alumno = new alumnoTableAdapter();
                    return alumno;
            }
        }
        //Metodos
        public DataTable listadoAlumnos()
        {
            return ALUMNO.GetData();
        }
        public int nuevoAlumno(string carne, string apellido1, string apellido2, string nombre1,
            string nombre2, DateTime fecha, string genero, int estado, string direccion,
            string telefono, DateTime fechaingreso, int idMuni)
        {
            try
            {
                ALUMNO.InsertaAlumno(carne, apellido1, apellido2, nombre1, nombre2, fecha, genero, estado, direccion, telefono, fechaingreso, idMuni);      
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}