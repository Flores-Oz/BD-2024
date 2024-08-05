using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Transactions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDPM24
{
    public partial class frmInscripción : Form
    {
        public frmInscripción()
        {
            InitializeComponent();
        }
        BD.BDLinqDataContext milinq = new BD.BDLinqDataContext();
        int idCiclo = 0;
        private void frmInscripción_Load(object sender, EventArgs e)
        {
            var listadoCarreras = from car in milinq.carrera
                                  select new
                                  {
                                      Codigo = car.id_carrera,
                                      Carrera = car.nombre_carrera
                                  };
            comboBoxCarrera.SelectedIndexChanged -= comboBoxCarrera_SelectedIndexChanged;
            comboBoxCarrera.DataSource = listadoCarreras;
            comboBoxCarrera.ValueMember = "Codigo";
            comboBoxCarrera.DisplayMember = "Carrera";
            comboBoxCarrera.SelectedIndexChanged += comboBoxCarrera_SelectedIndexChanged;

            var cicloActivo = from ci in milinq.ciclo
                              where ci.estado_ciclo == true
                              select new
                              {
                                  Codigo=ci.id_ciclo,
                                  Ciclo=ci.nombre_ciclo
                              };
            idCiclo = cicloActivo.ToList()[0].Codigo;
            labelCiclo.Text = cicloActivo.ToList()[0].Ciclo.ToString();
            //Cargar departamentos
            var cargarDepas = from depa in milinq.departamento
                              select new { 
                                CODIGO=depa.id_departamento,
                                DEPARTAMENTO=depa.nombre_departamento
                              };
            comboBoxDepa.DataSource = cargarDepas;
            comboBoxDepa.ValueMember = "CODIGO";
            comboBoxDepa.DisplayMember = "DEPARTAMENTO";

        }

        private void comboBoxCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

            string codCar = comboBoxCarrera.SelectedValue.ToString();
            var listadoGrados = from pen in milinq.pensum
                                where pen.id_carrera == codCar
                                select new
                                {
                                    Codigo = pen.id_grado,
                                    Grado = pen.grado.Nom_grado
                                };
            comboBoxGrado.DataSource = listadoGrados;
            comboBoxGrado.ValueMember = "Codigo";
            comboBoxGrado.DisplayMember = "Grado";
            //Encontrar el siguiente de carne
            string preCarne = labelCiclo.Text + codCar;
            var ultimoCarne = from alu in milinq.alumno
                              where alu.Carne.StartsWith(preCarne)
                              select alu.Carne;
            if (ultimoCarne.Max() == null)
            {
                labelCarne.Text = preCarne + "001";
            }
            else
            {
                string aux = ultimoCarne.Max().ToString();
                labelCarne.Text =(Convert.ToInt32(aux)+1).ToString();
            }
                                

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    //Alumno
                    milinq.alumno.InsertOnSubmit(new BD.alumno
                    {
                        Carne = labelCarne.Text,
                        nombre1_alumno = textBoxN1.Text,
                        nombre2_alumno = textBoxN2.Text,
                        apellido1_alumno = textBoxA1.Text,
                        apellido2_alumno = textBoxA2.Text,
                        Fechanac = Convert.ToDateTime(dtpFechaNac.Value.ToShortDateString()),
                        Sexo_Alumno = comboBoxGenero.Text,
                        estado_alumno = 1,
                        fechaingreso = DateTime.Now,
                        id_muni = Convert.ToInt32(comboBoxMuni.SelectedValue)
                    });
                    milinq.SubmitChanges();
                    //
                    //Inscripcion
                    BD.inscripcion nuevaIns = new BD.inscripcion();
                    nuevaIns.Carne = labelCarne.Text;
                    nuevaIns.Fecha_inicial = Convert.ToDateTime(labelCiclo.Text + "-01-01");
                    nuevaIns.Fecha_Final = Convert.ToDateTime(labelCiclo.Text + "-12-01");
                    nuevaIns.Estado_Ins = true;
                    var consulta = from pen in milinq.pensum
                                   where pen.id_carrera == comboBoxCarrera.SelectedValue.ToString()
                                   && pen.id_grado == Convert.ToInt32(comboBoxGrado.SelectedValue)
                                   select new
                                   {
                                       IDPEN = pen.ID_Pensum
                                   };
                    nuevaIns.ID_Pensum = consulta.ToList()[0].IDPEN;
                    nuevaIns.id_jornada = 1;
                    nuevaIns.id_ciclo = idCiclo;
                    var consultaPagos = from pc in milinq.Pagos_Grado
                                        where pc.id_carrera == comboBoxCarrera.SelectedValue.ToString()
                                        select new
                                        {
                                            VI = pc.Valor_Inscripcion,
                                            VM = pc.Valor_Mensualidad,
                                            TP = pc.cantidad_pagos
                                        };
                    decimal vi = consultaPagos.FirstOrDefault().VI;
                    decimal vm = consultaPagos.ToList()[0].VM;
                    int tp = Convert.ToInt32(consultaPagos.ToList()[0].TP);
                    nuevaIns.Cantidad_ins = vi;
                    nuevaIns.Cantidad_mensual = vm;
                    nuevaIns.Id_rubro_ins = 1;
                    nuevaIns.Id_rubro_men = 1;
                    nuevaIns.Contador_mes = 0;
                    decimal totalPagar = vm * tp + vi;
                    nuevaIns.Total_pagar = totalPagar;
                    nuevaIns.Fecha_Inscripcion = DateTime.Now;
                    nuevaIns.id_seccion = 1;
                    nuevaIns.id_usuario = 1;
                    milinq.inscripcion.InsertOnSubmit(nuevaIns);
                    milinq.SubmitChanges();
                    //
                    //Asigna Curso
                    string preFijo = DateTime.Now.ToString("yyyyMMdd");
                    var ultimoIDACA = from aca in milinq.asigna_cursosalum
                                      where aca.id_alum_curso.StartsWith(preFijo)
                                      select aca.id_alum_curso;
                    string idAca = "";
                    if (ultimoIDACA.Max() == null)
                        idAca = preFijo + "0001";
                    else
                        idAca = (Convert.ToInt64(ultimoIDACA.Max()) + 1).ToString();

                    var ultimoIDNota = from n in milinq.nota
                                       where n.ID_Nota.StartsWith(preFijo)
                                       select n.ID_Nota;
                    string idNota = "";
                    if (ultimoIDNota.Max() == null)
                        idNota = preFijo + "0001";
                    else
                        idNota = (Convert.ToInt64(ultimoIDNota.Max()) + 1).ToString();

                    var misCursos = from dp in milinq.detalle_pensum
                                    where dp.ID_Pensum == nuevaIns.ID_Pensum
                                    select new { IDCUR=dp.ID_Curso};
                    var misUnidades = from uni in milinq.unidad
                                      select new {IDUNI=uni.id_unidad };
                    foreach (var fila in misCursos)
                    {
                        BD.asigna_cursosalum nuevaAca = new BD.asigna_cursosalum { 
                            id_alum_curso=idAca,
                            ID_Inscripcion=nuevaIns.ID_Inscripcion,
                            ID_Curso=fila.IDCUR
                        };
                        milinq.asigna_cursosalum.InsertOnSubmit(nuevaAca);
                        foreach (var fUnidad in misUnidades)
                        {
                            BD.nota nuevaNota = new BD.nota { 
                                ID_Nota=idNota,
                                notafinal=0,
                                id_unidad=fUnidad.IDUNI,
                                zona=0,
                                total=0,
                                id_alum_curso=idAca,
                                tipo_nota="Normal"
                            };
                            milinq.nota.InsertOnSubmit(nuevaNota);
                            idNota = (Convert.ToInt64(idNota) + 1).ToString(); ;
                        }
                        idAca = (Convert.ToInt64(idAca) + 1).ToString();
                    }
                    milinq.SubmitChanges();
                    //

                    transa.Complete();
                    MessageBox.Show("Alumno ingresado");
                }
                catch
                {
                    transa.Dispose();                   
                    MessageBox.Show("Ocurrio un error");
                }
            }
        }

        private void comboBoxDepa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int codDepa = Convert.ToInt32(comboBoxDepa.SelectedValue);
                var cargaMunis = from muni in milinq.municipio
                                 where muni.id_departamento == codDepa
                                 select new
                                 {
                                     CODIGO = muni.id_municipio,
                                     MUNICIPIO = muni.nombre_municipio
                                 };
                comboBoxMuni.DataSource = cargaMunis;
                comboBoxMuni.ValueMember = "CODIGO";
                comboBoxMuni.DisplayMember = "MUNICIPIO";
            }
            catch { }
        }
    }
}
