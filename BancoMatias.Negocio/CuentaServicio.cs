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
        public void ModificarSaldo(float saldo, int idcuenta)
        {
            Cuenta c = new Cuenta();

            if (saldo < 0)
                throw new Exception("El saldo debe ser mayor a 0.");

            if (idcuenta <= 0)
                throw new Exception("Debe ser un id de cuenta valido.");

            TransactionResult t = mapper.Update(c);

            if (!t.IsOk)
            {
                throw new Exception("Error al modificar el saldo de la cuenta. " + t.Error);
            }
           
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
        public int ProximoNumeroCuenta()
        {
            List<Cuenta> cuenta = TraerCuentas();
            return cuenta.Max(c => c.NroCuenta) + 1;
        }
    }
}
