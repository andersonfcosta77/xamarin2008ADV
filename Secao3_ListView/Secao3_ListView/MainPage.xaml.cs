using Secao3_ListView.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Secao3_ListView
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ListaFuncionarios.ItemsSource = GetFuncionarios();
        }

        private List<Grupo> GetFuncionarios()
        {
            return new List<Grupo>
            {
                new Grupo("Presidente", "CEO")
                {
                    new Pessoa { Nome = "José" }
                },
                new Grupo("Diretores", "Dir.")
                {
                    new Pessoa { Nome = "João" },
                    new Pessoa { Nome = "Maria" },
                },
                new Grupo("Gerentes", "Ger.")
                {
                    new Pessoa { Nome = "Felipe" },
                    new Pessoa { Nome = "Judas" },
                },
            };

            //return new List<Pessoa>
            //{
            //    new Pessoa { Nome = "José" },
            //    new Pessoa { Nome = "João" },
            //    new Pessoa { Nome = "Maria" },
            //    new Pessoa { Nome = "Felipe" },
            //    new Pessoa { Nome = "Judas" },
            //};
        }
    }
}
