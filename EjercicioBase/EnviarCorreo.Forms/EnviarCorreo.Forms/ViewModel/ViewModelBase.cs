using EnviarCorreo.Forms.Classes;
using System.Windows.Input;
using Xamarin.Forms;

namespace EnviarCorreo.Forms.ViewModel
{
    public class ViewModelBase
    {
        public ICommand IdentificadorCommand { get; set; }

        public ViewModelBase(INavigation navigation)
        {
            IdentificadorCommand = new Command(() =>
            {
                //aquí es donde debes poner tu dirreción de correo
                string direccionCorreo = "micorreo@servicio.com";

                var cadenaIdentificador = DependencyService.Get<IIdentifierService>().ObtenerIdentificador(direccionCorreo);

                ServiceHelper servicioApp = new ServiceHelper();
                servicioApp.InsertarCorreo(cadenaIdentificador, direccionCorreo);
            });
        }
    }
}
