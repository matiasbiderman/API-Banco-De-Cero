using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BancoMatias.Entidades
{
    [DataContract]
    public class Cliente
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _email;
        private string _telefono;
        private DateTime _fechaNac;
        private bool _activo;
        private int _dni;

        [DataMember(Name = "id")]
        public int Id { get => _id; set => _id = value; }

        [DataMember(Name = "Nombre")]
        public string Nombre { get => _nombre; set => _nombre = value; }
        [DataMember(Name = "Apellido")]
        public string Apellido { get => _apellido; set => _apellido = value; }

        [DataMember(Name = "DNI")]
        public int DNI { get => _dni; set => _dni = value; }

        private string fechaNacimiento;
        [DataMember]
        public DateTime FechaNacimiento
        {
            get => Convert.ToDateTime(fechaNacimiento);
            set => fechaNacimiento = value.ToString();
        }

        [DataMember(Name = "Direccion")]
        public string Direccion { get => _direccion; set => _direccion = value; }
        [DataMember(Name = "Email")]
        public string Email { get => _email; set => _email = value; }

        [DataMember(Name = "Telefono")]
        public string Telefono { get => _telefono; set => _telefono = value; }

        [DataMember(Name = "activo")]
        public bool Activo { get => _activo; set => _activo = value; }
        
        public Cliente(int dni, string nombre, string ape, string dire, bool estado, string mail, string telefono, DateTime fecha, int id)
        {
            this._dni = dni;
            this._nombre = nombre;
            this._apellido = ape;
            this._direccion = dire;
            this._activo = estado;
            this._email = mail;
            this._telefono = telefono;
            this._fechaNac = fecha;
            this._id = id;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, Mail {3}, {4}, {5}", this.Nombre, this.Apellido, this.DNI, this.Email, this.Activo, this.FechaNacimiento);
        }
    }
}
