using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BancoMatias.Entidades
{
    [DataContract]
    public class Prestamo
    {
        private int _id;
        private double _tna;
        private string _linea;
        private int _plazo;
        private int _idcliente;
        private double _monto;
        private int _idtipo;
        private string _usuario;
        private TipoPrestamo tipo;
        private double _cuotaCapital;
        private double _cuotaInteres;
        private double _cuota;

        [DataMember(Name = "id")]
        public int Id { get => _id; set => _id = value; }
        [DataMember(Name = "plazo")]
        public int Plazo { get => _plazo; set => _plazo = value; }
        [DataMember(Name = "idCliente")]
        public int IdCliente { get => _idcliente; set => _idcliente = value; }
        [DataMember(Name = "linea")]
        public string Linea { get => _linea; set => _linea = value; }
        [DataMember(Name = "monto")]
        public double Monto { get => _monto; set => _monto = value; }
        
        [DataMember(Name = "tna")]
        public double Tna { get => _tna; set => _tna = value; }
        [DataMember(Name = "idtipo")]
        public int IdTipo { get => _idtipo; set => _idtipo = value; }
        [DataMember(Name = "tipoPrest")]
        public TipoPrestamo TipoPrest { get => tipo; set => tipo = value; }
        public double CuotaCapital { get => _cuotaCapital; set => _cuotaCapital = value; }
        public double CuotaInteres { get => _cuotaInteres; set => _cuotaInteres = value; }
        [DataMember(Name = "cuota")]
        public double CuotaTotal { get => _cuota; set => _cuota = value; }


        public Prestamo(int id, string linea, int plazo, double tna,double monto/*, double cuota,*/, int idcliente, int idtipo)
        {
            this._id = id;
            this._linea = linea;
            this._plazo = plazo;
            this._tna = tna;
            this._monto = monto;
            this._idcliente = idcliente;
            this._idtipo = idtipo;
            this._cuotaCapital = this._monto / this._plazo;
            this._cuotaInteres = this._cuotaCapital * (this._tna / 12 / 100);
            this._cuota = this._cuotaCapital + this._cuotaInteres;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2},{3}, {4}, {5}", this._id, this._monto, this.TipoPrest.Linea, this._plazo, this.TipoPrest.Tna, this.CuotaTotal);
        }
    }
}