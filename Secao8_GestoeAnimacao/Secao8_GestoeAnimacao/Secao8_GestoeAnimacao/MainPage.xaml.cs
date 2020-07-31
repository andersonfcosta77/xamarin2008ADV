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

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            count++;
            DisplayAlert("Tapped","Label1 foi tocada " + count + " vezes!1'","Ok");
        }
    }
}
