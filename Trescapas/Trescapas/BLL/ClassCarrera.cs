using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trescapas.DAL.DataSetGeneralTableAdapters;
//new library

namespace Trescapas.BLL
{
    internal class ClassCarrera
    {
        //atributos
        //instanciar la clase de carrera
        private carreraTableAdapter carrera = new carreraTableAdapter();
        //propiedades
        private carreraTableAdapter CARRERA 
        {
        
            get{ 
               if (carrera == null)
                {
                    carrera =new carreraTableAdapter();
                }
                return carrera;
            }
        
        }


        //metodos
        public  DataTable listadoCarrera()
        {
            return CARRERA.GetData();
        }

        public int NuevaCarrera(string codigo, string Nombre, bool Estado)
        {
            try
            {
                CARRERA.Insertacarrera(codigo, Nombre, Estado);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int EditaCarrera(string codigo, string Nombre, bool Estado)
        {
            try
            {
                CARRERA.EditaCarrera(Nombre, Estado, codigo);
                return 1;
            }
            catch
            {
                return 0;
            }

        }

    }
}
