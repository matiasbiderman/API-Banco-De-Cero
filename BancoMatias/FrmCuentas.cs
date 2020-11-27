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
    public partial class FrmCuentas : Form
    {
        ClienteServicio clienteServ;
        CuentaServicio cuentaServ;
        public FrmCuentas()
        {
            InitializeComponent();
            clienteServ = new ClienteServicio();
            cuentaServ = new CuentaServicio();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cmbCliente.SelectedItem;
            int idcliente = cliente.Id;
            listboxCuentas.DataSource = null;
            //listboxCuentas.Items.Add(cuentaServ.TraerPorCliente(idcliente));
            listboxCuentas.DataSource = cuentaServ.TraerPorCliente(idcliente);
        }

        private void FrmCuentas_Load(object sender, EventArgs e)
        {
            cmbCliente.DataSource = null;
            cmbCliente.DataSource = clienteServ.TraerPorCuentaExistente();
            txtnumerocuenta.Text = cuentaServ.ProximoNumeroCuenta().ToString();
            cmbdesc.DataSource = null;
            cmbdesc.DataSource = CargarDesc();
            cmbclienteagregar.DataSource = null;
            cmbclienteagregar.DataSource = clienteServ.TraerClientes();
        }
        private List<string> CargarDesc()
        {
            List<string> descs = new List<string>();
            descs.Add("Caja de Ahorro");
            descs.Add("Cuenta Corriente");
            return descs;
        }
        private void FrmCuentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listboxCuentas.DataSource = null;
            listboxCuentas.DataSource = cuentaServ.TraerCuentas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cuenta cuenta = CargarCuenta();
                cuentaServ.AgregarCuenta(cuenta);
                MessageBox.Show("La cuenta fue correctamente agregada");
                cmbCliente.DataSource = null;
                cmbCliente.DataSource = clienteServ.TraerPorCuentaExistente();
                txtnumerocuenta.Text = cuentaServ.ProximoNumeroCuenta().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private Cuenta CargarCuenta()
        {

            string descripcion = (string)cmbdesc.SelectedItem;
            Cliente cliente = (Cliente)cmbclienteagregar.SelectedItem;
            int idcli = cliente.Id;
            
            bool estado = checkBox1.Checked;

            string msj = "";

            msj += ValidacionesHelper.ValidarFloat(txtsaldo.Text, "Saldo");
            msj += ValidacionesHelper.ValidarInt(txtnumerocuenta.Text, "Numero de Cuenta");
            msj += ValidacionesHelper.ValidarSTRING(descripcion, "Descripcion");

            if (!string.IsNullOrWhiteSpace(msj))
            {
                throw new Exception(msj.ToString());
            }
            float saldo = float.Parse(txtsaldo.Text);
            int nrocuenta = int.Parse(txtnumerocuenta.Text);
            Cuenta cuenta = new Cuenta(cuentaServ.ProximoId(), nrocuenta, descripcion, idcli, estado, saldo);
            return cuenta;
        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            try
            {
                /*Cliente cliente = (Cliente)cmbCliente.SelectedItem;
                int idcli = cliente.Id;*/
                Cuenta cuenta = (Cuenta)listboxCuentas.SelectedItem;
                int idcuenta = cuenta.Id;
                cuentaServ.ModificarSaldo(float.Parse(txtsaldo.Text), idcuenta/*, idcli*/);
                MessageBox.Show("El saldo fue cambiado y pasara a tener " + txtsaldo.Text + " de saldo");

            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
