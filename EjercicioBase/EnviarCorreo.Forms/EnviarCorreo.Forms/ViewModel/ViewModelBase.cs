using EnviarCorreo.Forms.Classes;
using System.Windows.Input;
using Xamarin.Forms;

namespace EnviarCorreo.Forms.ViewModel
{
    public class ViewModelBase : VMBase
    {
        public ICommand IdentificadorCommand { get; set; }

        public ViewModelBase(INavigation navigation)
        {
            IdentificadorCommand = new Command(async() =>
            {
                //aquí es donde debes poner tu dirreción de correo
                string direccionCorreo = "amin.espinoza@gmail.com";
                string evento = "4389";

                ServiceHelper servicioApp = new ServiceHelper();
                await servicioApp.InsertarEntidad(direccionCorreo, evento);
                BtnText = "Reporte enviado";
            });

            BtnText = "Enviar Reporte";

        }

        private string _btnText;

        public string BtnText
        {
            get { return _btnText; }
            set
            {
                _btnText = value;
                OnPropertyChanged();
            }
        }


    }
}
