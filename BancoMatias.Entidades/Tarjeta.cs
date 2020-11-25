using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BancoMatias.Entidades
{
    [DataContract]
    public class Tarjeta
    {
        private int tipo;
        private int periodoVencimiento;
        private double limiteCompra;
        private string nroPlastico;
        private int idCliente;

        [DataMember]
        public int Tipo { get => tipo; set => tipo = value; }
        [DataMember]
        public int PeriodoVencimiento { get => periodoVencimiento; set => periodoVencimiento = value; }
        [DataMember]
        public double LimiteCompra { get => limiteCompra; set => limiteCompra = value; }
        [DataMember]
        public string NroPlastico { get => nroPlastico; set => nroPlastico = value; }
        [DataMember]
        public int IdCliente { get => idCliente; set => idCliente = value; }

        public Tarjeta(int _tipo, int idcli, double limite, string numplastico, int periodo)
        {
            this.tipo = _tipo;
            this.idCliente = idcli;
            this.limiteCompra = limite;
            this.nroPlastico = numplastico;
            this.periodoVencimiento = periodo;

        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", this.tipo, this.periodoVencimiento, this.limiteCompra, this.nroPlastico);
        }
    }
}
/*Tipo
integer($int32)
PeriodoVencimiento
integer($int32)
LimiteCompra
number($double)
NroPlastico
string
Usuario
string
idCliente
integer($int32)
*/