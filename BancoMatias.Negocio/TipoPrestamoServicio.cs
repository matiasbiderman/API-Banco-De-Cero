using BancoMatias.Datos;
using BancoMatias.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMatias.Negocio
{
    public class TipoPrestamoServicio
    {
        TipoPrestamoMapper mapper;
        public TipoPrestamoServicio()
        {
            mapper = new TipoPrestamoMapper();
        }

        public List<TipoPrestamo> TraerTipos()
        {
            List<TipoPrestamo> retorno = mapper.TraerTipos();
            return retorno;
        }
    }
}
