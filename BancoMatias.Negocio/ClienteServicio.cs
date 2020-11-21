﻿using BancoMatias.Datos;
using BancoMatias.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMatias.Negocio
{
    public class ClienteServicio
    {
        ClienteMapper mapper;
        public ClienteServicio()
        {
            mapper = new ClienteMapper();
        }
        public List<Cliente> TraerClientes()
        {
            List<Cliente> clientes = mapper.TraerTodos();
            return clientes;
        }
        public List<Cliente> TraerPorEstado(bool estado)
        {
            List<Cliente> clientes = mapper.TraerTodos();
            List<Cliente> retorno = new List<Cliente>();

            foreach (Cliente cliente in clientes)
            {
                if(cliente.Activo == estado)
                {
                    retorno.Add(cliente);
                }
            }
            return retorno;
        }
        public void AgregarCliente(Cliente cliente)
        {
            TransactionResult resultado = mapper.InsertarCliente(cliente);
            if (!resultado.IsOk)
            {
                throw new Exception("Error al agregar cliente. Detalle: " + resultado.Error);
            }
        }
        public int ProximoId()
        {
            List<Cliente> cliente = TraerClientes();
            return cliente.Max(c => c.Id) + 1;
        }
    }
}