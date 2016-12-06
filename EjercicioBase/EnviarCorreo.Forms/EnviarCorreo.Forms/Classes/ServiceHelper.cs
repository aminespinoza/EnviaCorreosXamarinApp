using Microsoft.WindowsAzure.MobileServices;
using System.Text;
using System.Security;
using System.Threading.Tasks;

namespace EnviarCorreo.Forms.Classes
{
    public class ServiceHelper
    {
        MobileServiceClient clienteServicio = new MobileServiceClient(@"http://encuestaclientes.azurewebsites.net");

        private IMobileServiceTable<Developer> _developerTable;

        public async Task InsertarEntidad(string direccionCorreo, string evento)
        {
            Developer nuevoRegistro = new Developer();
            nuevoRegistro.Email = direccionCorreo;
            nuevoRegistro.Event = evento;
            _developerTable = clienteServicio.GetTable<Developer>();
            await _developerTable.InsertAsync(nuevoRegistro);
        }
    }
}
