using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Secao3_ListView.Model
{
    public class SeletorTemplate : DataTemplateSelector
    {
        DataTemplate ItemPessoaObrigatoria;
        DataTemplate ItemPessoaNaoObrigatoria;

        public SeletorTemplate()
        {
            ItemPessoaObrigatoria = new DataTemplate(typeof(Templates.ItemPessoaObrigatorioViewCell));
            ItemPessoaNaoObrigatoria = new DataTemplate(typeof(Templates.ItemPessoaNaoObrigatorioViewCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Pessoa pessoa = item as Pessoa;
            if (pessoa.IsRequired)
            {
                return ItemPessoaObrigatoria;
            }
            else
            {
                return ItemPessoaNaoObrigatoria;
            }
            throw new NotImplementedException();
        }
    }
}
