using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public abstract class ItemBiblioteca
    {
        public bool Disponivel()
        {
            return Situacao == "Disponível";
        }
        public int Identificacao { get; set; }
        public string Titulo { get; set; }
        public string Situacao { get; set; }

        public ItemBiblioteca(int identificacao, string titulo)
        {
            Identificacao = identificacao;
            Titulo = titulo;
            Situacao = "Disponível";
        }

        public abstract string ToString();
    }

}
