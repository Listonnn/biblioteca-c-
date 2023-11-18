using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public class CadEmprestimos
    {
        private List<Emprestimo> emprestimos;

        public CadEmprestimos()
        {
            emprestimos = new List<Emprestimo>();
        }

        public void IncluirEmprestimo(Emprestimo emprestimo)
        {
            emprestimos.Add(emprestimo);
        }

        public void ExcluirEmprestimo(Emprestimo emprestimo)
        {
            emprestimos.Remove(emprestimo);
        }

        public int Tamanho()
        {
            return emprestimos.Count;
        }

        public Emprestimo ObterEmprestimo(int posicao)
        {
            if (posicao >= 0 && posicao < emprestimos.Count)
            {
                return emprestimos[posicao];
            }
            else
            {
                return null;
            }
        }

        public void Atrasos()
        {
            DateTime hoje = DateTime.Today;

            foreach (Emprestimo emprestimo in emprestimos)
            {
                if (emprestimo.DataDevolucao < hoje)
                {
                    emprestimo.Item.Situacao = "Atrasado";
                }
            }
        }
    }
}
