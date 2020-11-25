using BancoMatias.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMatias.Datos
{
    public class TarjetaMapper
    {
        public List<Tarjeta> TraerTodas()
        {
            string json = WebHelper.Get("/tarjetacredito/" + ConfigurationManager.AppSettings["Legajo"].ToString());
            List<Tarjeta> lista = JsonConvert.DeserializeObject<List<Tarjeta>>(json);
            return lista;
        }

        public TransactionResult InsertarTarejta(Tarjeta t)
        {
            NameValueCollection n = ReverseMap(t);
            string json = WebHelper.Post("/tarjetacredito", n);
            TransactionResult res = JsonConvert.DeserializeObject<TransactionResult> (json);
            return res;
        }
        private NameValueCollection ReverseMap(Tarjeta t)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idCliente",t.IdCliente.ToString());
            n.Add("Tipo",t.Tipo.ToString());
            n.Add("PeriodoVencimiento", t.PeriodoVencimiento.ToString());
            n.Add("LimiteCompra", t.LimiteCompra.ToString());
            n.Add("NroPlastico", t.NroPlastico);
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"].ToString());
            return n;
        }
    }
}

