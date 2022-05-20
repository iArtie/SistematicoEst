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
        public bool Verificar()
        {
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtLastname.Text) || String.IsNullOrEmpty(txtCarnet.Text) || String.IsNullOrEmpty(txtPhone.Text)
               || String.IsNullOrEmpty(txtAdress.Text) || String.IsNullOrEmpty(txtEmail.Text))
            {
                return false;
            }
            return true;
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
            Limpiar();
        }

        public void LoadDataGridView()
        {
            dtbEstudiantes.DataSource = estudianteService.GetAll();
        }

        private void btnUpt_Click(object sender, EventArgs e)
        {
            if (Verificar())
            {
                Estudiante estudiante = new Estudiante()
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
                    Estadistica = (int)nuEst.Value,
                };
                estudianteService.Update(estudiante);
                LoadDataGridView();
                Limpiar();
                MessageBox.Show($"Se ha actualizado los datos del estudiante {estudiante.Nombres} con Id {estudiante.Id}");
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos de información", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int index = dtbEstudiantes.CurrentCell.RowIndex;
            if (index >= 0)
            {
                Estudiante estudiante = estudianteService.GetAll()[index];
                estudianteService.Delete(estudiante);
                dtbEstudiantes.DataSource = null;
                dtbEstudiantes.DataSource = estudianteService.GetAll();
            }
        }

        private void Limpiar()
        {
            txtName.Text = string.Empty;
            txtLastname.Text = string.Empty;
            txtCarnet.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAdress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            ndMate.Value = 0;
            nuCont.Value = 0;
            nuProg.Value = 0;
            nuEst.Value = 0;
        }
    }
}
