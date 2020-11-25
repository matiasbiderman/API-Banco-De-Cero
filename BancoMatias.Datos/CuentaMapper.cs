using BancoMatias.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BancoMatias.Datos
{
    public class CuentaMapper
    {
        public List<Cuenta> TraerTodas()
        {
            string json = WebHelper.Get("/cuenta");
            List<Cuenta> cuentas = JsonConvert.DeserializeObject<List<Cuenta>>(json); // con esto me ahorro hacer el maplist
            return cuentas;
        }
        public TransactionResult Update(Cuenta cuenta)
        {
            NameValueCollection obj = Reverse(cuenta);

            string result = WebHelper.Post("/cuenta", obj);

            TransactionResult resultadoTransaccion = MapResultado(result);

            return resultadoTransaccion;
        }
        private NameValueCollection Reverse(Cuenta cuenta)
        {

            NameValueCollection n = new NameValueCollection();
            n.Add("id", cuenta.Id.ToString());
            n.Add("Saldo", cuenta.Saldo.ToString());
            return n;
        }
        public List<Cuenta> TraerPorCliente(int id)
        {
            string json = WebHelper.Get("/cuenta/" + id.ToString());
            List<Cuenta> cuentas = JsonConvert.DeserializeObject<List<Cuenta>>(json); // con esto me ahorro hacer el maplist
            return cuentas;
        }
        public TransactionResult InsertarCuenta(Cuenta cuenta)
        {
            NameValueCollection n = ReverseMap(cuenta);
            string res = WebHelper.Post("/cuenta", n);
            TransactionResult resultado = MapResultado(res);
            return resultado;
        }
        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
        private NameValueCollection ReverseMap(Cuenta cuenta)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("NroCuenta", cuenta.NroCuenta.ToString());
            n.Add("idCliente", cuenta.IdCliente.ToString());
            n.Add("Descripcion", cuenta.Descripcion);
            n.Add("Saldo", cuenta.Saldo.ToString());
            n.Add("Activo", cuenta.Activo.ToString());
            n.Add("id", cuenta.Id.ToString());
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            return n;
        }
    }
}
