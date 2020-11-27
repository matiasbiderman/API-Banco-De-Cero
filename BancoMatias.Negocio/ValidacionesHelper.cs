using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMatias.Negocio
{
    public static class ValidacionesHelper
    {
        public static string ValidarFecha(DateTime fecha)
        {
            string msj = "";
            if (fecha.AddYears(18) > DateTime.Today)
            {
                msj = "El cliente ingresado es menor de edad\n";// + Environment.NewLine;
            }
            return msj;
        }
        public static string ValidarDouble(string num, string campo)
        {
            string msj;
            double comprobacion = 0;

            if (string.IsNullOrEmpty(num))
            {
                msj = "El campo " + campo + " no debe estar vacio\n";// + Environment.NewLine;
            }
            else if (!double.TryParse(num, out comprobacion))
            {
                msj = "El campo " + campo + " debe ingresar un valor numerico\n";// + Environment.NewLine;
            }
            else if (comprobacion <= 0)
            {
                msj = "El campo " + campo + " debe ser positivo\n";// + Environment.NewLine;
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
                msj = "El campo " + campo + " no debe estar vacio\n";// + Environment.NewLine;
            }
            else
            {
                msj = "";
            }
            return msj;
        }

        public static string ValidarInt(string num, string campo)
        {
            string msj;
            int comprobacion = 0;

            if (string.IsNullOrEmpty(num))
            {
                msj = "El campo " + campo + " no debe estar vacio\n";// + Environment.NewLine;
            }
            else if (!int.TryParse(num, out comprobacion))
            {
                msj = "El campo " + campo + " debe ingresar un valor numerico\n"; //+ Environment.NewLine;
            }
            else if (comprobacion <= 0)
            {
                msj = "El campo " + campo + " debe ser positivo\n";// + Environment.NewLine;
            }
            else
            {
                msj = "";
            }
            return msj;
        }
        public static string ValidarFloat(string num, string campo)
        {
            string msj;
            float comprobacion = 0;

            if (string.IsNullOrEmpty(num))
            {
                msj = "El campo " + campo + " no debe estar vacio\n";// + Environment.NewLine;
            }
            else if (!float.TryParse(num, out comprobacion))
            {
                msj = "El campo " + campo + " debe ingresar un valor numerico\n";// + Environment.NewLine;
            }
            else if (comprobacion <= 0)
            {
                msj = "El campo " + campo + " debe ser positivo\n";//+ Environment.NewLine;
            }
            else
            {
                msj = "";
            }
            return msj;
        }
    }
}