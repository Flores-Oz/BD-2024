using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); IsMdiContainer = true;
            this.FormClosed += new FormClosedEventHandler(Inicio_FormClosed);
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void historialAcademicoDelProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialProfesor  a = new HistorialProfesor();
            a.MdiParent = this;
            a.Show();
        }

        private void listadoDeAlumnosAsignadosAUnCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CursoAlumno a = new CursoAlumno();
            a.MdiParent = this;
            a.Show();
        }
        
        private void listadoDeCursosAsignadosAUnAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnoCurso a = new AlumnoCurso();
            a.MdiParent = this;
            a.Show();
        }

        private void historialDeCursosDelAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialCursos a = new HistorialCursos();
            a.MdiParent = this;
            a.Show();
        }
    }
}
