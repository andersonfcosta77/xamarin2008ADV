using System;
using System.Collections.Generic;
using System.Text;

namespace Secao3_ListView.Model
{
    class Grupo : List<Pessoa>
    {
        public Grupo(string Titulo, String TituloCurto)
        {
            this.Titulo = Titulo;
            this.TituloCurto = TituloCurto;
        }

        public string Titulo { get; set; }
        public string TituloCurto { get; set; }
    }
}
