using System;
using Android.App;
using Android.Widget;
using Android.OS;
using EnviarCorreo.Nativo.Classes;

namespace EnviarCorreo.Nativo
{
    [Activity(Label = "EnviarCorreo.Nativo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button button;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            button = FindViewById<Button>(Resource.Id.btnReportar);
            button.Click += btnReportar_Click;
        }

        private void btnReportar_Click(object sender, EventArgs e)
        {
            ServiceHelper.InsertarEntidad("micorreo@servicio.com", "4389");
            button.Text = "Reporte enviado";
        }
    }
}

