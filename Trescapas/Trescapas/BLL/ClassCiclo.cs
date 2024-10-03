using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trescapas.DAL.DataSetGeneralTableAdapters;

namespace Trescapas.BLL
{
    internal class ClassCiclo
    {
        //atributos instancia de la clase
        private cicloTableAdapter Ciclo = new cicloTableAdapter();
        //encapsular, propiedades

        private cicloTableAdapter CICLO
        {
            get
            {
                if(Ciclo==null)
                    Ciclo = new cicloTableAdapter();
                return Ciclo;
            }
        }
        //metodos
        public DataTable ListadoCiclos()
        {
            return CICLO.GetData();
        }
    }
}
