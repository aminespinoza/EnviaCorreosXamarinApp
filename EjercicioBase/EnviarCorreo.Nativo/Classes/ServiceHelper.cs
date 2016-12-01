using System.Text;
using Microsoft.WindowsAzure.MobileServices;
using System.Security.Cryptography;

namespace EnviarCorreo.Nativo.Classes
{
    public static class ServiceHelper
    {
        static MobileServiceClient clienteServicio = new MobileServiceClient("http://encuestaclientes.azurewebsites.net");

        public async static void InsertarEntidad(string direccionCorreo, string evento)
        {
            Registros nuevoRegistro = new Registros();
            nuevoRegistro.identificador = ObtenerIdentificador(direccionCorreo);
            nuevoRegistro.correo = direccionCorreo;
            
            await clienteServicio.GetTable<Registros>().InsertAsync(nuevoRegistro);
        }

        private static string ObtenerIdentificador(string cadena)
        {
            SHA512 shaM = new SHA512Managed();
            byte[] data = shaM.ComputeHash(Encoding.UTF8.GetBytes(cadena));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            cadena = sBuilder.ToString();
            string cadenaFinal = cadena.Substring(0, 30);

            return (cadenaFinal);
        }
    }
}