using BancoMatias.Datos;
using BancoMatias.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMatias.Negocio
{
    public class CuentaServicio
    {
        CuentaMapper mapper;
        public CuentaServicio()
        {
            mapper = new CuentaMapper();
        }
        public List<Cuenta> TraerPorCliente(int id)
        {
            List<Cuenta> cuentas = mapper.TraerTodas();
            List<Cuenta> retorno = new List<Cuenta>();

            foreach (Cuenta cuenta in cuentas)
            {
                if (cuenta.IdCliente == id)
                {
                    retorno.Add(cuenta);
                }
            }
            return retorno;
        }
        public List<Cuenta> TraerCuentas()
        {
            List<Cuenta> cuentas = mapper.TraerTodas();
            
            return cuentas;
        }
        public void AgregarCuenta(Cuenta cuenta)
        {
            TransactionResult resultado = mapper.InsertarCuenta(cuenta);
            if (!resultado.IsOk)
            {
                throw new Exception("Error al agregar cliente. Detalle: " + resultado.Error);
            }
        }
        public int ProximoId()
        {
            List<Cuenta> cuenta = TraerCuentas();
            return cuenta.Max(c => c.Id) + 1;
        }
    }
}
