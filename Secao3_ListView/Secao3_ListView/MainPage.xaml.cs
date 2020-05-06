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
                new Grupo("Presidente", "CEO","Presidente da Empresa")
                {
                    new Pessoa { Nome = "José",
                                 RankingEficiencia= 8,
                                 IsRequired=true}
                },
                new Grupo("Diretores", "Dir.","Diretor da Empresa")
                {
                    new Pessoa { Nome = "João",
                                 RankingEficiencia=6,
                                 IsRequired=false },
                    new Pessoa { Nome = "Maria",
                                 RankingEficiencia=8,
                                 IsRequired=true },
                },
                new Grupo("Gerentes", "Ger.","Gerentes da Empresa")
                {
                    new Pessoa { Nome = "Felipe",
                                 RankingEficiencia=7,
                                 IsRequired=true },
                    new Pessoa { Nome = "Judas",
                                 RankingEficiencia=9,
                                 IsRequired=false },
                },
                new Grupo("Funcionarios", "Func.","Funcionarios da Empresa")
                {
                    new Pessoa { Nome = "Felipe",
                                 IsRequired=false },
                    new Pessoa { Nome = "Judas",
                                 IsRequired=false },
                    new Pessoa { Nome = "José", 
                                 IsRequired=false},
                    new Pessoa { Nome = "João", 
                                 IsRequired=true,
                                 RankingEficiencia=6 },
                    new Pessoa { Nome = "Maria", 
                                 IsRequired=false },
                    new Pessoa { Nome = "Felipe", 
                                 IsRequired=false },
                    new Pessoa { Nome = "Judas", 
                                 IsRequired=false },
                    new Pessoa { Nome = "Danilo",
                                 IsRequired=false },
                    new Pessoa { Nome = "Jessica",
                                 IsRequired=false },
                    new Pessoa { Nome = "Hellem",
                                 IsRequired=false },
                    new Pessoa { Nome = "Debora",
                                 IsRequired=false },
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
