using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMatias.Negocio
{
    public static class ValidacionesHelper
    {
        public static string ValidarNumero(string num, string campo)
        {
            string msj;
            int comprobacion = 0;
            if (!int.TryParse(num, out comprobacion))
            {
                msj = "El campo " + campo + " debe ingresar un valor numerico" + Environment.NewLine;
            }
            else if (comprobacion <= 0)
            {
                msj = "El campo " + campo + " debe ser positivo" + Environment.NewLine;
            }
            else
            {
                msj = "";
            }
            return msj;

        }
        public static string ValidarSTRING(string dato, string campo)
        {
            string msj;

            if (string.IsNullOrWhiteSpace(dato))
            {
                msj = "El campo " + campo + " no debe estar vacio" + Environment.NewLine;
            }
            else
            {
                msj = "";
            }
            return msj;

        }
        public static string ValidarSaldo(string num, string campo, ref float salida)
        {
            string msj;

            if (!float.TryParse(num, out salida))
            {
                msj = "El campo " + campo + " debe ingresar un valor numerico" + Environment.NewLine;
            }
            else if (salida <= 0)
            {
                msj = "El campo " + campo + " debe ser positivo" + Environment.NewLine;
            }
            else
            {
                msj = "";
            }
            return msj;

        }

        public static string ValidarMonto(string num, string campo, ref double salida)
        {
            string msj;

            if (!double.TryParse(num, out salida))
            {
                msj = "El campo " + campo + " debe ingresar un valor numerico" + Environment.NewLine;
            }
            else if (salida <= 0)
            {
                msj = "El campo " + campo + " debe ser positivo" + Environment.NewLine;
            }
            else
            {
                msj = "";
            }
            return msj;

        }
    }
}