using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Grupo1Animaciones.Vistas;
using Plugin.SharedTransitions;
namespace Grupo1Animaciones
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SharedTransitionNavigationPage(new Animaciones());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
