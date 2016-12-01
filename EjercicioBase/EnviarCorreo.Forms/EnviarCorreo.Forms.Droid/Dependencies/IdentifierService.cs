using System;
using EnviarCorreo.Forms.Classes;
using System.Security.Cryptography;
using System.Text;
using EnviarCorreo.Forms.Droid.Dependencies;

[assembly: Xamarin.Forms.Dependency (typeof(IdentifierService))]
namespace EnviarCorreo.Forms.Droid.Dependencies
{
    public class IdentifierService : IIdentifierService
    {
        public string ObtenerIdentificador(string cadenaRecibida)
        {
            SHA512 shaM = new SHA512Managed();
            byte[] data = shaM.ComputeHash(Encoding.UTF8.GetBytes(cadenaRecibida));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            cadenaRecibida = sBuilder.ToString();
            string cadenaFinal = cadenaRecibida.Substring(0, 30);

            return (cadenaFinal);
        }
    }
}