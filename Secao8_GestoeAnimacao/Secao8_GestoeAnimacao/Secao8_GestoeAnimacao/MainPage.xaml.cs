using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Secao8_GestoeAnimacao
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public MainPage()
        {
            InitializeComponent();
            //Tipos de Gesture
            // Tap - toque ou clique
            // Pinch - pinça
            // Pan - Toque e arrasta

            //Adiconado Gesture Pan via CodeBehind
            //OBS.: Poderia ser utilizado a mesma forma que foi feito para o Tapped via XAML
            PanGestureRecognizer pan = new PanGestureRecognizer();
            pan.PanUpdated += PanGestureRecognizer_Tapped;
            MyLabel.GestureRecognizers.Add(pan);
        }

        private void PanGestureRecognizer_Tapped(object sender, PanUpdatedEventArgs e)
        {
            //MyLabel.Text = e.TotalX + " - " + e.TotalY;
            if (e.StatusType == GestureStatus.Running)
            {
                Rectangle rect = new Rectangle(e.TotalX, e.TotalY, 200, 25);
                AbsoluteLayout.SetLayoutBounds(MyLabel, rect);
                AbsoluteLayout.SetLayoutFlags(MyLabel, AbsoluteLayoutFlags.None);
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            count++;
            DisplayAlert("Tapped","Label1 foi tocada " + count + " vezes!1'","Ok");
        }
        private void TapGestureRecognizer_Tapped_LabelBoxView(object sender, EventArgs e)
        {
            count++;
            MyBox.TranslateTo(100, 250, 1000, Easing.BounceOut);
            MyBox.ScaleTo(2, 1000);
            MyBox.FadeTo(0.5, 1000);
            MyBox.RotateTo(45, 1000);
        }
    }
}
