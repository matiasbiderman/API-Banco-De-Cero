using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BancoMatias.Datos
{
    public static class WebHelper
    {
        static WebClient client;
        static string rutaBase;
        static WebHelper()
        {
            client = new WebClient();
            client.Encoding = Encoding.UTF8;
            rutaBase = ConfigurationManager.AppSettings["URL_API"];
            client.Headers.Add("ContentType", "application/json");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }
        public static string Get(string url)
        {
            string urlCompleta = rutaBase + url;
            string responseString = client.DownloadString(urlCompleta);
            return responseString;
        }
        public static string Post(string url, NameValueCollection parametros)
        {
            string urlCompleta = rutaBase + url;
            try
            {
                var response = client.UploadValues(urlCompleta, parametros);
                var responseString = Encoding.Default.GetString(response);
                return responseString;
            }
            catch (Exception ex)
            {
                return "{ \"isOk\":false,\"id\":-1,\"error\":\"Error en el llamado al servicio\"}";
            }
        }
    }
}
