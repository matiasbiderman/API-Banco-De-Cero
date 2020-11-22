using BancoMatias.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMatias.Datos
{
    public class TipoPrestamoMapper
    {
        public List<TipoPrestamo> TraerTipos()
        {
            string json = WebHelper.Get("/prestamotipo");
            List<TipoPrestamo> retorno = JsonConvert.DeserializeObject<List<TipoPrestamo>>(json);
            return retorno;
        }
    }
}
