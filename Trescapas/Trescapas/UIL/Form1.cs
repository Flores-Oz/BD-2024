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

namespace Trescapas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClassCarrera logicaCarrera= new ClassCarrera();
        private void Form1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = logicaCarrera.listadoCarrera();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int respuesta = logicaCarrera.NuevaCarrera(
                textEditCodigo.Text,
                textEditnombre.Text,
                checkEditestado.Checked
                );
            if( respuesta == 1)
            {
                MessageBox.Show("Exitoso");
                gridControl1.DataSource = logicaCarrera.listadoCarrera();
            }
            else
                MessageBox.Show("Eror");
        }
    }
}
