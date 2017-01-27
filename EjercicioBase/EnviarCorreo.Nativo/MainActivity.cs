using System;
using Android.App;
using Android.Widget;
using Android.OS;
using EnviarCorreo.Nativo.Services;

namespace EnviarCorreo.Nativo
{
    [Activity(Label = "EnviarCorreo.Nativo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button bactionButton;
        string emailBase = "amin.espinoza@outlook.com";
        string codeBase = "upt";

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            bactionButton = FindViewById<Button>(Resource.Id.btnReportar);
            bactionButton.Click += btnReportar_Click;
        }

        private async void btnReportar_Click(object sender, EventArgs e)
        {
            ServiceHelper serviceHelper = new ServiceHelper();
            if (emailBase == "amin.espinoza@gmail.com" || codeBase == "iniciativa")
            {
                throw new Exception("Recuerda cambiar el correo y código del correo");

            }
            await serviceHelper.InsertarEntidad(emailBase, codeBase);
            bactionButton.Text = "Reporte enviado";
            bactionButton.Enabled = false;
            Toast.MakeText(this, "Tienes correo nuevo!", ToastLength.Short).Show();
        }
    }
}

