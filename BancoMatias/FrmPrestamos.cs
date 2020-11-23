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
    public partial class FrmPrestamos : Form
    {
        TipoPrestamoServicio tiposervicio;
        PrestamoServicio prestamoservicio;
        ClienteServicio clienteserv;
        public FrmPrestamos()
        {
            InitializeComponent();
            prestamoservicio = new PrestamoServicio();
            tiposervicio = new TipoPrestamoServicio();
            clienteserv = new ClienteServicio();
        }

        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            lstTipoPrestamo.DataSource = null;
            lstTipoPrestamo.DataSource = tiposervicio.TraerTipos();
            CargarListaPrestamo();
            CalculadoraComisionTotal();
            comboBox1.DataSource = null;
            comboBox1.DataSource = clienteserv.TraerPorCuentaExistente();
        }

        private void CargarListaPrestamo()
        {
            lstPrestamos.DataSource = null;
            lstPrestamos.DataSource = prestamoservicio.TraerPrestamos();
        }
        private void FrmPrestamos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
            this.Hide();
        }
        private void CalculadoraComisionTotal()
        {
            double comision = prestamoservicio.CalcularComision();
            textBox8.Text = comision.ToString();
        }
        private void lstTipoPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoPrestamo tipo = (TipoPrestamo)lstTipoPrestamo.SelectedItem;
            txtlinea.Text = tipo.Linea;
            txttna.Text = tipo.Tna.ToString();
        }

        private void btnsimular_Click(object sender, EventArgs e)
        {
            CargarPrestamo();
        }
        private Prestamo CargarPrestamo()
        {
            string linea = txtlinea.Text;
            double tna = double.Parse(txttna.Text);
            double monto = double.Parse(txtmonto.Text);
            int plazo = int.Parse(txtplazo.Text);
            TipoPrestamo tipo = (TipoPrestamo)lstTipoPrestamo.SelectedItem;
            int idtipo = tipo.Id;
            Cliente cliente = (Cliente)comboBox1.SelectedItem;
            int idcliente = cliente.Id;
            Prestamo p = new Prestamo(prestamoservicio.ProximoId(), linea, plazo, tna, monto, idcliente, idtipo);
            txtcuotacap.Text = p.CuotaCapital.ToString();
            txtcuotaint.Text = p.CuotaInteres.ToString();
            txtcuotatot.Text = p.CuotaTotal.ToString();

            return p;
        }

        private void btnalta_Click(object sender, EventArgs e)
        {
            try
            {
                Prestamo prestamo = CargarPrestamo();
                prestamoservicio.AgregarPrestamos(prestamo);
                MessageBox.Show("Prestamo Agregado Correctamente");
                CargarListaPrestamo();
                CalculadoraComisionTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
