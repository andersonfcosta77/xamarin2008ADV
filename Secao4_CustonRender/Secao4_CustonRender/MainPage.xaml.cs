﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Secao4_CustonRender
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            Button myButton = new Button();
            myButton.Text = "Eu sou diferente!";
            myButton.TextColor = Color.Coral;
            
            ContainerObj.Children.Add(myButton);
        }
    }
}
