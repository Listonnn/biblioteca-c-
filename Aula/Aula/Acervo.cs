using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public class Acervo
    {
        private List<ItemBiblioteca> itens;

        public Acervo()
        {
            itens = new List<ItemBiblioteca>();
        }

        public void IncluirItem(ItemBiblioteca item)
        {
            itens.Add(item);
        }

        public int Tamanho()
        {
            return itens.Count;
        }

        public ItemBiblioteca ObterItem(int posicao)
        {
            if (posicao >= 0 && posicao < itens.Count)
            {
                return itens[posicao];
            }
            else
            {
                throw new IndexOutOfRangeException("Posição inválida");
            }
        }

        public void ExcluirItem(int identificacao)
        {
            ItemBiblioteca item = itens.Find(i => i.Identificacao == identificacao);
            if (item != null)
            {
                itens.Remove(item);
            }
            else
            {
                throw new Exception("Item não encontrado");
            }
        }
    }
}
