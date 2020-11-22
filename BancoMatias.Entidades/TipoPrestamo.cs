using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BancoMatias.Entidades
{
    [DataContract]
    public class TipoPrestamo
    {
        private int _id;
        private string linea;
        private double tna;

        [DataMember(Name = "id")]
        public int Id { get => _id; set => _id = value; }

        [DataMember(Name = "linea")]
        public string Linea { get => linea; set => linea = value; }

        [DataMember(Name = "tna")]
        public double Tna { get => tna; set => tna = value; }

        public override string ToString()
        {
            return string.Format("{0}, {1}", this._id, this.linea, this.tna);
        }
    }
}
