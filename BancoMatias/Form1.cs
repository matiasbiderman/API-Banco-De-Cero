using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoMatias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            FrmClientes formulario = new FrmClientes();
            formulario.Owner = this;
            formulario.Show();
            this.Hide();
        }

        private void btnListarCuentas_Click(object sender, EventArgs e)
        {
            FrmCuentas formulario = new FrmCuentas();
            formulario.Owner = this;
            formulario.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmPrestamos formulario = new FrmPrestamos();
            formulario.Owner = this;
            formulario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTarjetas formulario = new FrmTarjetas();
            formulario.Owner = this;
            formulario.Show();
            this.Hide();
        }
    }
}
