using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Grupo1Animaciones.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Animaciones : ContentPage
    {
        public Animaciones()
        {
            InitializeComponent();
        }

        private async void btnRotar_Clicked(object sender, EventArgs e)
        {
            await Frame.RotateTo(360, 1000, Easing.BounceIn);
            await Frame.RotateTo(0, 1000, Easing.BounceIn);

        }

        private async void btnTraslate_Clicked(object sender, EventArgs e)
        {
            await Frame.TranslateTo(100, 0, 500, Easing.BounceOut);
            await Frame.TranslateTo(100, -100, 500, Easing.BounceOut);
            await Frame.TranslateTo(0, 0, 500, Easing.BounceOut);

        }

        private async void btnScala_Clicked(object sender, EventArgs e)
        {
            await Frame.ScaleTo(2, 1000);
            await Frame.ScaleTo(0.5, 1000);
            await Frame.ScaleTo(1, 1000);

        }

        private async void btnFade_Clicked(object sender, EventArgs e)
        {
            await Frame.FadeTo(0, 1000);
            await Frame.FadeTo(1, 1000);


        }

        private async void btnRotarX_Clicked(object sender, EventArgs e)
        {
            await Frame.RotateXTo(180, 1000);
            await Frame.RotateXTo(0, 1000);


        }

        private async void btnRotarY_Clicked(object sender, EventArgs e)
        {
            await Frame.RotateYTo(180, 1000);
            await Frame.RotateYTo(0, 1000);
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Compras());

        }
    }
}