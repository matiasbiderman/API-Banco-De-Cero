using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BancoMatias.Entidades
{
    [DataContract]
    public class Cuenta
    {
        private int _nrocuenta;
        private string _descripcion;
        private float _saldo;
        private DateTime fechaApertura;
        private int idcliente;
        private int _id;
        private bool activo;
        
        [DataMember(Name = "id")]
        public int Id { get => _id; set => _id = value; }

        [DataMember(Name = "descripcion")]
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        [DataMember(Name = "nroCuenta")]
        public int NroCuenta { get => _nrocuenta; set => _nrocuenta = value; }
        [DataMember(Name = "idCliente")]
        public int IdCliente { get => idcliente; set => idcliente = value; }
        [DataMember(Name = "activo")]
        public bool Activo { get => activo; set => activo = value; }
        [DataMember(Name = "saldo")]
        public float Saldo { get => _saldo; set => _saldo = value; }

        public Cuenta(int id, int cuenta, string desc, int idcli, bool activo, float saldo)
        {
            this._id = id;
            this._nrocuenta = cuenta;
            this._descripcion = desc;
            this.idcliente = idcli;
            this.activo = activo;
            this._saldo = saldo;
        }
        public override string ToString()
        {
            return string.Format("{0},{1}, {2}", this.Saldo, this.NroCuenta, this.Descripcion);
        }
    }
}