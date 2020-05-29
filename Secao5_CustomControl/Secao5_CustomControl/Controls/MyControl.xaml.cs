using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Secao5_CustomControl.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyControl : ContentView
    {
        public MyControl()
        {
            InitializeComponent();
        }

        //--------------------
        //Evento - Tapped
        //--------------------
        public event EventHandler Tapped;

        //--------------------
        //Titulo
        //--------------------
        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set { SetValue(TituloProperty, value); }
        }

        public static readonly BindableProperty TituloProperty = BindableProperty.Create(
            propertyName: "Titulo",
            returnType: typeof(string),
            declaringType: typeof(MyControl),
            defaultValue: "",
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: TituloPropertyChanged
        );

        private static void TituloPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var myControl = (MyControl)bindable;
            myControl.titulo.Text = (string)newValue;
        }

        //--------------------
        //TituloCor
        //--------------------
        public Color TituloCor
        {
            get { return (Color)GetValue(TituloCorProperty); }
            set { SetValue(TituloCorProperty, value); }
        }

        public static readonly BindableProperty TituloCorProperty = BindableProperty.Create(
            propertyName: "TituloCor",
            returnType: typeof(Color),
            declaringType: typeof(MyControl),
            defaultValue: Color.Black,
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: TituloCorPropertyChanged
        );

        private static void TituloCorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var myControl = (MyControl)bindable;
            myControl.titulo.TextColor = (Color)newValue;
        }

        //--------------------
        //Imagem
        //--------------------
        public string Imagem
        {
            get { return (string)GetValue(ImagemProperty); }
            set { SetValue(ImagemProperty, value); }
        }

        public static readonly BindableProperty ImagemProperty = BindableProperty.Create(
            propertyName: "Imagem",
            returnType: typeof(string),
            declaringType: typeof(MyControl),
            defaultValue: "",
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: ImagemPropertyChanged
            );

        private static void ImagemPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var myControl = (MyControl)bindable;
            myControl.imagem.Source = (string)newValue;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (Tapped != null)
            {
                Tapped(sender, e);
            }
        }
    }
}