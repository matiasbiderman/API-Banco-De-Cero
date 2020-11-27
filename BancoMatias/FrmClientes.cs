using BancoMatias.Entidades;
using BancoMatias.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoMatias
{
    public partial class FrmClientes : Form
    {
        ClienteServicio _clienteServicio;
        public FrmClientes()
        {
            InitializeComponent();
            _clienteServicio = new ClienteServicio();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CmbEstado.DataSource = null;
            CmbEstado.DataSource = CargarComboEstado();
        }
        private List<string> CargarComboEstado()
        {
            List<string> estados = new List<string>();
            estados.Add("ACTIVO");
            estados.Add("INACTIVO");
            return estados;
        }
        private void CmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string combo = (string)CmbEstado.SelectedItem;
            bool estado = false;
            if (combo == "ACTIVO")
                estado = true;
            else if (combo == "INACTIVO")
                estado = false;
            listboxClientes.DataSource = null;
            listboxClientes.DataSource = _clienteServicio.TraerPorEstado(estado);
        }

        private void FrmClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listboxClientes.DataSource = null;
            listboxClientes.DataSource = _clienteServicio.TraerClientes();
        }
        private void CargarListaCliente()
        {
            listboxClientes.DataSource = null;
            listboxClientes.DataSource = _clienteServicio.TraerClientes();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e) //AGREGAR CLIENTE
        {
            try
            {
                Cliente cliente = CargarCliente();
                _clienteServicio.AgregarCliente(cliente);
                MessageBox.Show("Cliente ingresado correctamente");
                CargarListaCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private Cliente CargarCliente()
        {
            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;
            string direccion = txtdireccion.Text;
            string mail = txtmail.Text;
            string telefono = txttelefono.Text;
           
            bool estado = checkBox1.Checked;
            DateTime fechanac = dateTimePicker1.Value;

            string msj = "";

            msj += ValidacionesHelper.ValidarFecha(fechanac);
            msj += ValidacionesHelper.ValidarInt(txtdni.Text, "Dni");
            msj += ValidacionesHelper.ValidarSTRING(nombre, "Nombre");
            msj += ValidacionesHelper.ValidarSTRING(apellido, "Apellido");
            msj += ValidacionesHelper.ValidarSTRING(direccion, "Direccion");
            msj += ValidacionesHelper.ValidarSTRING(mail, "Email");
            msj += ValidacionesHelper.ValidarSTRING(telefono, "Telefono");

            if (!string.IsNullOrWhiteSpace(msj))
            {
                throw new Exception(msj.ToString());
            }
            int dni = int.Parse(txtdni.Text);
            Cliente cliente = new Cliente(dni, nombre, apellido, direccion, estado, mail, telefono, fechanac, _clienteServicio.ProximoId());

            return cliente;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }
    }
}
