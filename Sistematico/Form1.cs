using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Sistematico.Applications.Interfaces;
using Sistematico.Domain.Entities;

namespace Sistematico
{
    public partial class Form1 : Form
    {
        private IEstudianteService estudianteService;

        public Form1(IEstudianteService estudianteService)
        {
            this.estudianteService = estudianteService;
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Estudiante estudiantes = new Estudiante()
            {
                Nombres = txtName.Text,
                Apellidos = txtLastname.Text,
                Carnet = txtCarnet.Text,
                Phone = txtPhone.Text,
                Direccion = txtAdress.Text,
                Correo = txtEmail.Text,
                Matematicas = (int)ndMate.Value,
                Contabilidad = (int)nuCont.Value,
                Programacion = (int)nuProg.Value,
                Estadistica = (int)nuEst.Value
            };
            estudianteService.Create(estudiantes);
            LoadDataGridView();
        }

        public void LoadDataGridView() 
        {
            dtbEstudiantes.DataSource = estudianteService.GetAll();
        }
    }
}
