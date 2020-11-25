using BancoMatias.Datos;
using BancoMatias.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMatias.Negocio
{
    public class PrestamoServicio
    {
        PrestamoMapper mapper;
        public PrestamoServicio()
        {
            mapper = new PrestamoMapper();
        }
        public List<Prestamo> TraerPrestamos()
        {
            List<Prestamo> prestamos = mapper.TraerPrestamos();
            return prestamos;
        }
        public void AgregarPrestamos(Prestamo p)
        {
            TransactionResult t = mapper.InsertarPrestamo(p);
            if (!t.IsOk)
            {
                throw new Exception("Error al agregar empleado.Detalle: " + t.Error);
            }
        }
        public double CalcularComision()
        {
            double comision = 0;
            Operador operador = new Operador(mapper.TraerPrestamos());
            foreach (Prestamo p in operador.Prestamos)
            {
                comision += p.CuotaInteres * p.Plazo * operador.PorcentajeComision;
            }
            return comision;
        }
        public int ProximoId()
        {
            List<Prestamo> prestamos = TraerPrestamos();
            return prestamos.Max(p => p.Id) + 1;
        }
    }
}
