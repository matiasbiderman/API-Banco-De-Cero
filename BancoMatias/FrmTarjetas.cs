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

        private int AlgoritmoPeriodoSemanal()
        {
            string periodo = (string)cmbPeriodo.SelectedItem;
            int periodoVencimiento = 0;
            switch (periodo)
            {
                case "Primera Semana":
                    periodoVencimiento = 1;
                    break;
                case "Segunda Semana":
                    periodoVencimiento = 2;
                    break;
                case "Tercera Semana":
                    periodoVencimiento = 3;
                    break;
                case "Cuarta Semana":
                    periodoVencimiento = 4;
                    break;
            }
            return periodoVencimiento;
        }

        private Tarjeta EntradaDatosFormulario()
        {
            int tipoTarjeta = (int)Tipo.Amex;
            Tarjeta t = null;
            int periodo = AlgoritmoPeriodoSemanal();
            Cliente cliente = (Cliente)cmbCliente.SelectedItem;
            int idcliente = cliente.Id;
            double limite = double.Parse(txtlimite.Text);
            string numero = txtnumplas.Text;
            
            string msj = "";

            msj += ValidacionesHelper.ValidarNumero(limite.ToString(), "Limite Compra");
            msj += ValidacionesHelper.ValidarSTRING(numero, "Numero de Plastico");

            if (!string.IsNullOrWhiteSpace(msj))
            {
                throw new Exception(msj.ToString());
            }
            
            t = new Tarjeta(tipoTarjeta, idcliente, limite, numero, periodo);
            return t;
        }
        private Tarjeta CargarTarjeta()
        {
            Tarjeta t = null;
            string tipo = (string)cmbTipo.SelectedItem;
            if (!tarjetaServicio.ValidoLimiteCompra(clienteServicio.TraerPorCuentaExistente(), double.Parse(txtlimite.Text)))
            {
                if (tipo == "AMEX")
                {
                    if (txtnumplas.Text.Length == 15)
                        t = EntradaDatosFormulario();
                    else
                        throw new Exception("Para AMEX el numero debe tener 15 digitos");
                }
                else if (tipo == "MasterCard")
                {
                    if (txtnumplas.Text.Length == 16)
                        t = EntradaDatosFormulario();
                    else
                        throw new Exception("Para MasterCard el numero debe tener 15 digitos");
                }
                else if (tipo == "Visa")
                {
                    if (txtnumplas.Text.Length == 16)
                        t = EntradaDatosFormulario();
                    else
                        throw new Exception("Para Visa el numero debe tener 15 digitos");
                }
            }
            else
            {
                throw new Exception("Limite de compra mayor al saldo de la cuenta");
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
