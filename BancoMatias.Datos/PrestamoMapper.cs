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
    public class PrestamoMapper
    {
        public List<Prestamo> TraerPrestamos()
        {
            string json = WebHelper.Get("/prestamo/891830");
            List<Prestamo> prestamos = JsonConvert.DeserializeObject<List<Prestamo>>(json);
            return prestamos;
        }

        public TransactionResult InsertarPrestamo(Prestamo p)
        {
            NameValueCollection n = ReverseMap(p);
            string json = WebHelper.Post("/prestamo", n);
            TransactionResult t = JsonConvert.DeserializeObject<TransactionResult>(json);
            return t;
        }

        private NameValueCollection ReverseMap(Prestamo p)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Linea", p.Linea);
            n.Add("Monto", p.Monto.ToString() );
            n.Add("Id", p.Id.ToString() );
            n.Add("TNA",p.Tna.ToString().Replace(',', '.'));
            n.Add("Plazo", p.Plazo.ToString());
            n.Add("idCliente", p.IdCliente.ToString());
            n.Add("idTipo", p.IdTipo.ToString());
            n.Add("Cuota", p.CuotaTotal.ToString());
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            return n;
            //n.Add("", p.TipoPrest.ToString());


        }
    }
}
