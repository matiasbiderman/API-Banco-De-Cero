using BancoMatias.Entidades;
using BancoMatias.Negocio;
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
    public partial class FrmTarjetas : Form
    {
        private TarjetaServicio tarjetaServicio;
        private ClienteServicio clienteServicio;
        public FrmTarjetas()
        {
            InitializeComponent();
            clienteServicio = new ClienteServicio();
            tarjetaServicio = new TarjetaServicio();
        }

        private void FrmTarjetas_Load(object sender, EventArgs e)
        {
            cmbTipo.DataSource = null;
            cmbTipo.DataSource = CargarListaTipo();
            cmbCliente.DataSource = null;
            cmbCliente.DataSource = clienteServicio.TraerPorCuentaExistente();
            cmbPeriodo.DataSource = null;
            cmbPeriodo.DataSource = CargarListaPeriodo();
            CargarListbox();
        }
        private void CargarListbox()
        {
            listBoxTarjetas.DataSource = null;
            listBoxTarjetas.DataSource = tarjetaServicio.TraerTarjertas();
        }
        private List<string> CargarListaTipo()
        {
            List<string> lista = new List<string>();
            lista.Add("AMEX");
            lista.Add("MasterCard");
            lista.Add("Visa");

            return lista;
        }
        private List<string> CargarListaPeriodo()
        {
            List<string> lista = new List<string>();
            lista.Add("Primera Semana");
            lista.Add("Segunda Semana");
            lista.Add("Tercera Semana");
            lista.Add("Cuarta Semana");

            return lista;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Tarjeta t = CargarTarjeta();
                tarjetaServicio.AgregarTarjerta(t);
                MessageBox.Show("Tarjeta de credito agregada correctamente");
                BlanquearCampos();
                CargarListbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BlanquearCampos();
            }

        }
        private Tarjeta CargarTarjeta()
        {
            int tipoTarjeta = 0;
            Tarjeta t = null;
            string tipo = (string)cmbTipo.SelectedItem;
            if (tipo == "AMEX")
            {
                tipoTarjeta = (int)Tipo.Amex;
                string periodo = (string)cmbPeriodo.SelectedItem;
                Cliente cliente = (Cliente)cmbCliente.SelectedItem;
                int idcliente = cliente.Id;
                double limite = double.Parse(txtlimite.Text);
                string numero = txtnumplas.Text;
                t = new Tarjeta(tipoTarjeta, idcliente, limite, numero, 1);
            }
            else if (tipo == "MasterCard")
            {
                tipoTarjeta = (int)Tipo.MasterCard;
                string periodo = (string)cmbPeriodo.SelectedItem;
                Cliente cliente = (Cliente)cmbCliente.SelectedItem;
                int idcliente = cliente.Id;
                double limite = double.Parse(txtlimite.Text);
                string numero = txtnumplas.Text;
                t = new Tarjeta(tipoTarjeta, idcliente, limite, numero, 1);
            }
            else if (tipo == "Visa")
            {
                tipoTarjeta = (int)Tipo.Visa;
                string periodo = (string)cmbPeriodo.SelectedItem;
                Cliente cliente = (Cliente)cmbCliente.SelectedItem;
                int idcliente = cliente.Id;
                double limite = double.Parse(txtlimite.Text);
                string numero = txtnumplas.Text;
                t = new Tarjeta(tipoTarjeta, idcliente, limite, numero, 1);
            }

            if (t == null)
                throw new Exception("tiene un error en la carga de la tarjeta, intente nuevamente");
            return t;

        }
        private void BlanquearCampos()
        {
            txtlimite.Text = string.Empty;
            txtnumplas.Text = string.Empty;
        }
        private void FrmTarjetas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
            this.Hide();
        }
    }
}
