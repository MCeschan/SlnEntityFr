using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFEscuela.Dac;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela
{
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            MostrarTodosAlumnos();
        }

        private void MostrarTodosAlumnos()
        {
            GridAlumnos.DataSource = AbmAlumno.SelectAll();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno() { Nombre = "Gustavo", Apellido="Rosales", FechaNacimiento= new DateTime(1998, 10, 10)};

            int filasAfectadas = AbmAlumno.Insert(alumno);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("insert ok");
                MostrarTodosAlumnos();


            }
        }

        private void btnTraerUno_Click(object sender, EventArgs e)
        {
            int id = 1;

            Alumno alumno = AbmAlumno.SelectWhereById(id);
            MessageBox.Show(alumno.Nombre);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno() { Nombre = "Pablo", Apellido = "Rosales", IdAlumno = 1 };

            int filasAfectadas = AbmAlumno.Update(alumno);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Update ok");
                MostrarTodosAlumnos();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno() { Nombre = "Gustavo", Apellido = "Rosales", IdAlumno = 1 };

            int filasAfectadas = AbmAlumno.Delete(alumno);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete ok");
                MostrarTodosAlumnos();

            }
        }
    }
}
