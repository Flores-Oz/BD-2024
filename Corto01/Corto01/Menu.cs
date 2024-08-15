using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corto01
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            IsMdiContainer = true;
            this.FormClosed += new FormClosedEventHandler(Inicio_FormClosed);
        }
        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void carneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Curso a = new Curso();
            a.MdiParent = this;
            a.Show();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumno a = new Alumno();
            a.MdiParent = this;
            a.Show();
        }
    }
}
