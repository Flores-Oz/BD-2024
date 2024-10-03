using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trescapas.BLL;

namespace Trescapas.UIL
{
    public partial class FRMciclo : Form
    {
        public FRMciclo()
        {
            InitializeComponent();
        }
        ClassCiclo logicacliclo=new ClassCiclo();
        private void FRMciclo_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = logicacliclo.ListadoCiclos();
        }
    }
}
