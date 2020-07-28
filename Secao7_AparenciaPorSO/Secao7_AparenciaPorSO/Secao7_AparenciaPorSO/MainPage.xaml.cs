using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Secao7_AparenciaPorSO
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //------------------------------------------------------------------------
            //Background do formulário de acordo com o tipo de equipamento.
            //------------------------------------------------------------------------
            //Exibir conteúdo de acordo com o tipo de equipamento
            //if (Device.Idiom == TargetIdiom.Tablet)
            //{
            //    Container.BackgroundColor = Color.Aqua;
            //}
            //if (Device.Idiom == TargetIdiom.Phone)
            //{
            //    Container.BackgroundColor = Color.Yellow;
            //}

            //------------------------------------
            //Margens em SOs diferentes
            //------------------------------------
            //Existem duas opções diferentes para indicaro o SO
            //if (Device.OS == TargetPlatform.iOS)
            //{
            //    Container.Margin = new Thickness(0, 10, 0, 0);
            //}
            //if (Device.OS == TargetPlatform.Android)
            //{
            //    Container.Margin = new Thickness(0, 50, 0, 0);
            //}

            //Thickness Margin = Thickness(0, 50, 0, 0);
            //Device.OnPlatform(iOS: () =>
            //{
            //    Margin = new Thickness(0, 20, 0, 0);
            //},
            //Android: () =>
            //{
            //    Margin = new Thickness(0, 50, 0, 0);
            //});
            //Container.Margin = Margin;
        }
    }
}
