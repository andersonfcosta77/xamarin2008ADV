using System;
using System.Collections.Generic;
using System.Text;

namespace Secao3_ListView.Model
{
    class Grupo : List<Pessoa>
    {
        public Grupo(string Titulo, String TituloCurto, string Descricao)
        {
            this.Titulo = Titulo;
            this.TituloCurto = TituloCurto;
            this.Descricao = Descricao;
        }

        public string Titulo { get; set; }
        public string TituloCurto { get; set; }
        public string Descricao { get; set; }
    }
}
