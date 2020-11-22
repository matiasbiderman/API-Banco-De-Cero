using BancoMatias.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMatias.Datos
{
    public class ClienteMapper
    {
        public List<Cliente> TraerTodos()
        {
            string json = WebHelper.Get("/cliente/891830");
            List<Cliente> clientes = JsonConvert.DeserializeObject<List<Cliente>>(json); // con esto me ahorro hacer el maplist
            return clientes;
        }
        public TransactionResult InsertarCliente(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            string result = WebHelper.Post("/cliente", obj);
            TransactionResult resultado = MapResultado(result);
            return resultado;
        }
        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Dni", cliente.DNI.ToString());
            n.Add("Nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Apellido);
            n.Add("Direccion", cliente.Direccion);
           n.Add("Telefono", cliente.Telefono);
            n.Add("Email", cliente.Email);
           // n.Add("fechaNacimiento", cliente.FechaNacimiento.ToString());
            n.Add("Activo", cliente.Activo.ToString());
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            n.Add("id", cliente.Id.ToString());
            return n;

           
        }

    }
}

