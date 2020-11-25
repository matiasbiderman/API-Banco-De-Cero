using BancoMatias.Datos;
using BancoMatias.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMatias.Negocio
{
    public class TarjetaServicio
    {
        private TarjetaMapper mapper;
        private CuentaMapper mapperCuenta;
        public TarjetaServicio()
        {
            mapperCuenta = new CuentaMapper();
            mapper = new TarjetaMapper();
        }

        public List<Tarjeta> TraerTarjertas()
        {
            List<Tarjeta> lista = mapper.TraerTodas();
            return lista;
        }
        public void AgregarTarjerta(Tarjeta tarjeta)
        {
            TransactionResult t = mapper.InsertarTarejta(tarjeta);
            if (!t.IsOk)
            {
                throw new Exception("No se puede agregar tarjeta. Detalle: " + t.Error);
            }
        }

        public bool ValidoLimiteCompra(List<Cliente> clientes, double limite)
        {
            bool retorno = false;
            double resultado = limite * 18;
            List<Cuenta> cuentas = mapperCuenta.TraerTodas();
            foreach (Cliente cliente in clientes)
            {
                foreach (Cuenta cuenta in cuentas)
                {
                    if (cuenta.IdCliente == cliente.Id)
                    {
                       if(resultado > cuenta.Saldo)
                        {
                            retorno = true;
                        }
                    }
                }
            }
            return retorno;
        }
    }
}
