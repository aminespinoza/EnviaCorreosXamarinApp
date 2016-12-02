using EnviarCorreo.Forms.ViewModel;
using Xamarin.Forms;

namespace EnviarCorreo.Forms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ViewModelBase(this.Navigation);
        }
    }
}
