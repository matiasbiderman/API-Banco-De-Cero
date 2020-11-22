using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMatias.Entidades
{
    public class Operador
    {
        private List<Prestamo> _prestamos;
        private double _comision;
        private double _porcentajeComision;
        public Operador(List<Prestamo> prestamos)
        {
            this._prestamos = prestamos;
            this._porcentajeComision = 0.15;
        }
        public List<Prestamo> Prestamos { get => _prestamos; set => _prestamos = value; }
        public double Comision { get => _comision; set => _comision = value; }
        public double PorcentajeComision { get => _porcentajeComision; }
       
    }
}
