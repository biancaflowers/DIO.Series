using System;

namespace DIO.Series
{
    class Program
    {

        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[]args)
        {
            string opcaoUsuario = opcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1";
                    listarSeries();
                    break;
                    case "2";
                    InserirSerie();
                    break;
                    case "3";
                    AtualizarSerie();
                    break;
                    case "4";
                    ExcluirSerie();
                    break;
                    case "5";
                    VisualizarSerie();
                    break;
                    case "C";
                    Console.Clear();
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = new ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();

            Serie meuObjeto = new Serie();
        }

        private static void listarSeries()
        {
            Console.WriteLine("Listar Séries");
            var lista = repositorio.Lista();
            if (lista.Count == 0)
            Console.WriteLine("Nenhuma série Cadastrada");
            return;
        }
        foreach (var serie in lista)
        {
            Console.WriteLine("#ID {0}: - {1}," , serie.retornaId(), serie.retornaTitulo());
        }

    
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Dio Séries!");
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova Série");
            Console.WriteLine("3- Atualizar Série");
            Console.WriteLine("4- Excluir Série");
            Console.WriteLine("5- Visualizar Série");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}

