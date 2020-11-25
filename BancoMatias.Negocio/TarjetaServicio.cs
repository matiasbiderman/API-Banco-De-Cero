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
        public TarjetaServicio()
        {
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
    }
}
