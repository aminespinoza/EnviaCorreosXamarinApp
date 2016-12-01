using Microsoft.WindowsAzure.MobileServices;
using System.Text;
using System.Security;

namespace EnviarCorreo.Forms.Classes
{
    public class ServiceHelper
    {
        MobileServiceClient clienteServicio = new MobileServiceClient("http://encuestaclientes.azurewebsites.net");

        public async void InsertarEntidad(string identificador, string direccionCorreo, string evento)
        {
            Registros nuevoRegistro = new Registros();
            nuevoRegistro.identificador = identificador;
            nuevoRegistro.correo = direccionCorreo;
            nuevoRegistro.evento = evento;

            await clienteServicio.GetTable<Registros>().InsertAsync(nuevoRegistro);
        }
    }
}
