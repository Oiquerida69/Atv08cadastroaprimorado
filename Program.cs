using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv08cadastrodeusuarios
{

    class Program
    {
        static List<string> nomes = new List<string>();

        static void Main()
        {
            int opcao = 0;

            do
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Buscar");
                Console.WriteLine("3 - Deletar");
                Console.WriteLine("4 - Alterar");
                Console.WriteLine("5 - Listar usuarios");
                Console.WriteLine("0 - Sair");

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarUsuario();
                        break;
                    case 2:
                        BuscarUsuario();
                        break;
                    case 3:
                        DeletarUsuario();
                        break;
                    case 4:
                        AlterarUsuario();
                        break;
                    case 5:
                        
                    case 0:
                        Console.WriteLine("Programa encerrado.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine();
            } while (opcao != 0);
        }

        static void CadastrarUsuario()
        {
            Console.WriteLine("Digite o nome do novo usuário:");
            string nome = Console.ReadLine();
            nomes.Add(nome);
            Console.WriteLine("Usuário cadastrado com sucesso!");
        }

        static void BuscarUsuario()
        {
            if (nomes.Count == 0)
            {
                Console.WriteLine("A lista está vazia ainda...");
            }
            else
            {
                Console.WriteLine("Digite o índice do usuário que deseja buscar:");
                int indice = Convert.ToInt32(Console.ReadLine());

                if (indice >= 0 && indice < nomes.Count)
                {
                    string nome = nomes[indice];
                    Console.WriteLine($"Nome encontrado: {nome}");
                }
                else
                {
                    Console.WriteLine("Essa posição não existe");
                }
            }
        }

        static void DeletarUsuario()
        {
            if (nomes.Count == 0)
            {
                Console.WriteLine("A lista está vazia ainda...");
            }
            else
            {
                Console.WriteLine("Digite o índice do usuário que deseja deletar:");
                int indice = Convert.ToInt32(Console.ReadLine());

                if (indice >= 0 && indice < nomes.Count)
                {
                    nomes.RemoveAt(indice);
                    Console.WriteLine("Registro deletado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Essa posição não existe");
                }
            }
        }

        static void AlterarUsuario()
        {
            if (nomes.Count == 0)
            {
                Console.WriteLine("A lista está vazia ainda...");
            }
            else
            {
                Console.WriteLine("Digite o nome do usuário que deseja alterar:");
                string nomeAntigo = Console.ReadLine();

                int indice = nomes.IndexOf(nomeAntigo);

                if (indice >= 0)
                {
                    Console.WriteLine("Digite o novo nome:");
                    string novoNome = Console.ReadLine();

                    nomes[indice] = novoNome;
                    Console.WriteLine("Nome alterado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Esse nome não existe na lista");
                }
            }
        }
        static void ListarUsuarios()
        {
            int contador = 0;
            while( contador < nomes.Count )
            {
                Console.WriteLine(nomes[contador]);
                contador++;
            }

    }
}
