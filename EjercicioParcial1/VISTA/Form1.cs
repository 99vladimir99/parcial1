using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioParcial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTel_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'eMPLEADODataSet.Tbl_empleado' Puede moverla o quitarla según sea necesario.
            this.tbl_empleadoTableAdapter.Fill(this.eMPLEADODataSet.Tbl_empleado);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtEmpleado.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDUI.Clear();
            txtDireccion.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            txtCargo.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                String Id = dtgEmpleados.CurrentRow.Cells[0].Value.ToString();
                String Nombre = dtgEmpleados.CurrentRow.Cells[1].Value.ToString();
                String Apellido = dtgEmpleados.CurrentRow.Cells[2].Value.ToString();
                String DUI = dtgEmpleados.CurrentRow.Cells[3].Value.ToString();
                String Direccion = dtgEmpleados.CurrentRow.Cells[4].Value.ToString();
                String Telefono = dtgEmpleados.CurrentRow.Cells[5].Value.ToString();
                String Email = dtgEmpleados.CurrentRow.Cells[6].Value.ToString();
                String Cargo = dtgEmpleados.CurrentRow.Cells[7].Value.ToString();

                txtEmpleado.Text = Id;
                txtNombre.Text = Nombre;
                txtApellido.Text = Apellido;
                txtDUI.Text = DUI;
                txtDireccion.Text = Direccion;
                txtTel.Text = Telefono;
                txtEmail.Text = Email;
                txtCargo.Text = Cargo;
            }
        }
    }
}
