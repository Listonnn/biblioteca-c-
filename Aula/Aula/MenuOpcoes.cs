using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula.Usuarios;
using Aula.Acervo;
using Aula.CadEmprestimos;
using Aula.ItemBiblioteca;

namespace Aula
{
    public class MenuOpcoes
    {
        private Usuarios usuarios;
        private Acervo acervo;
        private CadEmprestimos cadEmprestimos;

        public MenuOpcoes()
        {
            usuarios = new Usuarios();
            acervo = new Acervo();
            cadEmprestimos = new CadEmprestimos();
        }

        public void CadastrarUsuario()
        {
            // Lógica para cadastrar um usuário na classe Usuarios
            // Exemplo:
            Console.WriteLine("Digite o nome do usuário:");
            string nome = Console.ReadLine();
            Usuario usuario = new Usuario(nome);
            usuarios.IncluirUsuario(usuario);
        }

        public void CadastrarItemBiblioteca()
        {
            // Lógica para cadastrar um item da biblioteca na classe Acervo
            // Exemplo:
            Console.WriteLine("Digite o título do item:");
            string titulo = Console.ReadLine();
            Console.WriteLine("Digite o tipo do item (Livro, Periódico ou DVD):");
            string tipo = Console.ReadLine();
            ItemBiblioteca item = null;
            if (tipo == "Livro")
            {
                item = new Livro(titulo);
            }
            else if (tipo == "Periódico")
            {
                item = new Periodico(titulo);
            }
            else if (tipo == "DVD")
            {
                item = new DVD(titulo);
            }
            acervo.IncluirItem(item);
        }

        public void RealizarEmprestimo()
        {
            // Lógica para realizar um empréstimo, verificando se o usuário e o item estão disponíveis
            // e armazenando o empréstimo na classe CadEmprestimos
            // Exemplo:
            Console.WriteLine("Digite o nome do usuário:");
            string nomeUsuario = Console.ReadLine();
            Usuario usuario = usuarios.ObterUsuarioPorNome(nomeUsuario);
            if (usuario == null)
            {
                Console.WriteLine("Usuário não encontrado.");
                return;
            }

            Console.WriteLine("Digite o título do item:");
            string tituloItem = Console.ReadLine();
            ItemBiblioteca item = acervo.ObterItemPorTitulo(tituloItem);
            if (item == null)
            {
                Console.WriteLine("Item não encontrado.");
                return;
            }

            try
            {
                cadEmprestimos.RealizarEmprestimo(usuario, item);
                Console.WriteLine("Empréstimo realizado com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RealizarDevolucao()
        {
            // Lógica para realizar a devolução de um empréstimo, tornando o item disponível novamente
            // e excluindo o empréstimo da classe CadEmprestimos
            // Exemplo:
            Console.WriteLine("Digite o número de identificação do empréstimo:");
            int identificacao = int.Parse(Console.ReadLine());
            Emprestimo emprestimo = cadEmprestimos.ObterEmprestimoPorIdentificacao(identificacao);
            if (emprestimo == null)
            {
                Console.WriteLine("Empréstimo não encontrado.");
                return;
            }

            cadEmprestimos.RealizarDevolucao(emprestimo);
            Console.WriteLine("Devolução realizada com sucesso.");
        }

        public void ListarUsuarios()
        {
            // Lógica para listar todos os usuários da classe Usuarios
            // Exemplo:
            Console.WriteLine("Lista de Usuários:");
            foreach (Usuario usuario in usuarios.ObterTodosUsuarios())
            {
                Console.WriteLine(usuario.Nome);
            }
        }

        public void ListarLivros()
        {
            // Lógica para listar todos os livros do acervo, com sua situação
            // Exemplo:
            Console.WriteLine("Lista de Livros:");
            foreach (Livro livro in acervo.ObterTodosLivros())
            {
                Console.WriteLine($"Título: {livro.Titulo}, Situação: {livro.Situacao}");
            }
        }

        public void ListarPeriodicos()
        {
            // Lógica para listar todos os periódicos do acervo, com sua situação
            // Exemplo:
            Console.WriteLine("Lista de Periódicos:");
            foreach (Periodico periodico in acervo.ObterTodosPeriodicos())
            {
                Console.WriteLine($"Título: {periodico.Titulo}, Situação: {periodico.Situacao}");
            }
        }

        public void ListarDVDs()
        {
            // Lógica para listar todos os DVDs do acervo, com sua situação
            // Exemplo:
            Console.WriteLine("Lista de DVDs:");
            foreach (DVD dvd in acervo.ObterTodosDVDs())
            {
                Console.WriteLine($"Título: {dvd.Titulo}, Situação: {dvd.Situacao}");
            }
        }

        public void ListarEmprestimos()
        {
            // Lógica para listar todos os empréstimos da classe CadEmprestimos, ordenados por data de devolução
            // Exemplo:
            Console.WriteLine("Lista de Empréstimos:");
            foreach (Emprestimo emprestimo in cadEmprestimos.ObterTodosEmprestimosOrdenadosPorDataDevolucao())
            {
                Console.WriteLine($"Usuário: {emprestimo.Usuario.Nome}, Item: {emprestimo.Item.Titulo}, Data de Empréstimo: {emprestimo.DataEmprestimo}, Data de Devolução: {emprestimo.DataDevolucao}");
            }
        }

        public void ExcluirUsuario()
        {
            // Lógica para excluir um usuário, verificando se ele não possui itens emprestados
            Console.WriteLine("Digite o nome do usuário:");
            string nomeUsuario = Console.ReadLine();
            Usuario usuario = usuarios.ObterUsuarioPorNome(nomeUsuario);
            if (usuario == null)
            {
                Console.WriteLine("Usuário não encontrado.");
                return;
            }

            if (usuario.ItemEmprestado != null)
            {
                Console.WriteLine("O usuário possui itens emprestados e não pode ser excluído.");
                return;
            }

            usuarios.ExcluirUsuario(usuario);
            Console.WriteLine("Usuário excluído com sucesso.");
        }

        public void ExcluirItem()
        {
            // Lógica para excluir um item do acervo, verificando se ele está na situação "disponível"
            // Exemplo:
            Console.WriteLine("Digite o título do item:");
            string tituloItem = Console.ReadLine();
            ItemBiblioteca item = acervo.ObterItemPorTitulo(tituloItem);
            if (item == null)
            {
                Console.WriteLine("Item não encontrado.");
                return;
            }

            if (item.Situacao != "Disponível")
            {
                Console.WriteLine("O item não está disponível e não pode ser excluído.");
                return;
            }

            acervo.ExcluirItem(item);
            Console.WriteLine("Item excluído com sucesso.");
        }
    }
}
