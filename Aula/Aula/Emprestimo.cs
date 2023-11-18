using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public class Emprestimo
    {
        public int Identificacao { get; set; }
        public Usuario Usuario { get; set; }
        public ItemBiblioteca Item { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }

        public Emprestimo(int identificacao, Usuario usuario, ItemBiblioteca item)
        {
            Identificacao = identificacao;
            Usuario = usuario;
            Item = item;
            DataEmprestimo = DateTime.Now;
            DefinirDataDevolucao(item);
        }

        public void Emprestar(Usuario usuario, ItemBiblioteca item, int prazo)
        {
            if (item.Situacao == "Disponível" && usuario.ItemEmprestado == null)
            {
                Usuario = usuario;
                Item = item;
                DataEmprestimo = DateTime.Now;
                DefinirDataDevolucao(item, prazo);
                item.Situacao = "Emprestado";
                usuario.ItemEmprestado = item;
            }
            else
            {
                throw new Exception("Não é possível realizar o empréstimo");
            }
        }

        public void Retornar()
        {
            Item.Situacao = "Disponível";
            Usuario.ItemEmprestado = null;
        }

        public override string ToString()
        {
            return $"Empréstimo: {Identificacao}\nUsuário: {Usuario.Nome}\nItem: {Item.Titulo}\nData de Empréstimo: {DataEmprestimo}\nData de Devolução: {DataDevolucao}";
        }

        private void DefinirDataDevolucao(ItemBiblioteca item)
        {
            if (item is Livro)
            {
                DataDevolucao = DataEmprestimo.AddDays(7);
            }
            else if (item is Periodico)
            {
                DataDevolucao = DataEmprestimo.AddDays(4);
            }
            else if (item is DVD)
            {
                DataDevolucao = DataEmprestimo.AddDays(2);
            }
        }
    }
}