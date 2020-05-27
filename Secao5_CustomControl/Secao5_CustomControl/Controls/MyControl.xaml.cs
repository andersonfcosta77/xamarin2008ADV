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
        //Titulo
        public static readonly BindableProperty TituloProperty = BindableProperty.Create(
            propertyName:"Titulo",
            returnType:typeof(string),
            declaringType:typeof(MyControl),
            defaultValue: "",
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: TituloPropertyChanged
            );

        public string Titulo
        {
            get { return (string)GetValue(TituloProperty);}
            set { SetValue(TituloProperty, value); }
        }

        private static void TituloPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var myControl = (MyControl)bindable;
            myControl.titulo.Text = (string)newValue;
        }


        //TituloCor
        public static readonly BindableProperty TituloCorProperty = BindableProperty.Create(
            propertyName: "TituloCor",
            returnType: typeof(Color),
            declaringType: typeof(MyControl),
            defaultValue: Color.Black,
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: TituloCorPropertyChanged
            );

        public Color TituloCor
        {
            get { return (Color)GetValue(TituloCorProperty); }
            set { SetValue(TituloCorProperty, value); }
        }

        private static void TituloCorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var myControl = (MyControl)bindable;
            myControl.titulo.TextColor = (Color)newValue;
        }


        public MyControl()
        {
            InitializeComponent();
        }
    }
}