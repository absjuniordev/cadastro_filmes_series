using System;
using dio.SERIES;
using static System.Console;

namespace dio.SERIES
{
    class Program
    {
        static FilmeRepositorio filmeRepositorio = new FilmeRepositorio();
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            int i = 0;

            string OpcaoUsuario = Apresentacao();

            while (OpcaoUsuario.ToUpper() != "X")
            {

                if (OpcaoUsuario == "1")
                {
                    OpcaoSerie();
                }
                if (OpcaoUsuario == "2")
                {
                    OpcaoFilme();
                }
                else
                {

                    WriteLine("Opcção Invalida");
                }
                i++;
                if (i == 3)
                {
                    Clear();
                    i = 0;
                }

                OpcaoUsuario = Apresentacao();
            }
            WriteLine("Obrigado por utilizar os serviços");
            ReadLine();
        }

        private static string Apresentacao()
        {
            WriteLine("-----------------------------------------");
            WriteLine("A  S U A  L O C A D O R A  D I G I T A L ");
            WriteLine("O que deseja cadastrar?");
            WriteLine("1- Series");
            WriteLine("2- Filmes");
            WriteLine("x- Sair");
            WriteLine("-----------------------------------------");
            string OpcaoUsuario = ReadLine().ToUpper();
            return OpcaoUsuario;
        }

        private static void OpcaoSerie()
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {

                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSeries();
                        break;
                    case "3":
                        AtualizarSeries();
                        break;
                    case "4":
                        ExcluirSeries();
                        break;
                    case "5":
                        VisualizarSeries();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }

                opcaoUsuario = ObterOpcaoUsuario();
            }


            static void ListarSeries()
            {
                WriteLine("Listar séries");

                var lista = repositorio.Lista();//a variavel 'lista' recebera o conteudo da varavel repositorio do metodo Lista 

                if (lista.Count == 0)//se o tamanho da lista for = a zero
                {
                    WriteLine("Nenhuma série cadastrada");
                    return;// para sair do metodo
                }
                foreach (var serie in lista)
                {
                    var excluido = serie.retornaExcluido();//ira pegar o valor F/V pois é booleano
                    WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excuildo*" : ""));
                    //est arranjo (excluido ? "*Excuildo*" : "") server para verifa se é F/V
                }
            }

            static void InserirSeries()//melhoreia criar um metodo que posssa economizar linhas
            {//e assi usar em AtualizarLista tambem
                foreach (int i in Enum.GetValues(typeof(Genero)))//ira fazer uma varredura na lista de generos que enumeramos com o Enum
                {//se um novo genero foi add, este codigo não se altera
                    WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));//imprimirar o nome e o numore correspondente
                }

                WriteLine("Digite o gênero entre as oções acima: ");//entrada
                int entradaGenero = int.Parse(ReadLine());//capitura

                WriteLine("Digite o titulo da série: ");
                string entradaTitulo = ReadLine();

                WriteLine("Digite o ano de lançamento da série: ");
                int entradaAno = int.Parse(ReadLine());

                WriteLine("Digite a descrição da série: ");
                string entradaDescricao = ReadLine();

                Serie novaSerie = new Serie(id: repositorio.ProximoId(),//esta condição ira criar um id para cada criação nova
                              genero: (Genero)entradaGenero,//insere o conteudo capturado no parametro.*em especial o (Genero) pq ele esta apontando o unum
                              titulo: entradaTitulo,
                              ano: entradaAno,
                              descricao: entradaDescricao);
                repositorio.Insere(novaSerie);//insere os dados coletados no repositorio                                      
            }
            static async void AtualizarSeries()
            {
                WriteLine("Digite o id da série: ");
                int indiceSerie = int.Parse(ReadLine());

                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                    WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
                }
                WriteLine("Digite o genero entre as opções acima: ");
                int entradaGenero = int.Parse(ReadLine());

                WriteLine("Digite o titulo da série: ");
                string entradaTitulo = ReadLine();

                WriteLine("Digite ano de inicio da série: ");
                int entradaAno = int.Parse(ReadLine());

                WriteLine("Digite a descrição da série: ");
                string entradaDescricao = ReadLine();

                Serie atualizSerie = new Serie(id: indiceSerie,//pegamos o propio id que o usuario digitou
                                      genero: (Genero)entradaGenero,
                                      titulo: entradaTitulo,
                                      ano: entradaAno,
                                      descricao: entradaDescricao);

                repositorio.Atualiza(indiceSerie, atualizSerie);//sobrescreve                                           
            }
            static void ExcluirSeries()
            {
                WriteLine("Digite o id da série: ");
                int indiceSerie = int.Parse(ReadLine());
                //melhoria confirmar com o usuario se realmente deseja excluir
                repositorio.Exclui(indiceSerie);
            }
            static void VisualizarSeries()
            {
                WriteLine("Digite o id da série:");
                int indiceSerie = int.Parse(ReadLine());

                var serie = repositorio.RetornaPortaId(indiceSerie);//variavel do repositorio>metodo>valor
                WriteLine(serie);//retornará o id inserido e ira consolidar com as infomações do metodo 'ToString()'
            }


            static string ObterOpcaoUsuario()
            {
                WriteLine();
                WriteLine("JR Series a seu dispo!!!");
                WriteLine("Informe a opção desejada");

                WriteLine("1- Listar séries");
                WriteLine("2- Inserir nova série");
                WriteLine("3- Atualizar séries");
                WriteLine("4- Excluir séries");
                WriteLine("5- Visualizar séries");
                WriteLine("C- Limpar tela");
                WriteLine("R- Retornar");
                WriteLine();

                string opcaoUsuario = ReadLine().ToUpper();//indiferente do tipo A ou a
                WriteLine();
                return opcaoUsuario;
            }

        }
        private static void OpcaoFilme()
        {
            {
                string opcaoUsuario = ObterOpcaoUsuario();

                while (opcaoUsuario.ToUpper() != "X")
                {

                    switch (opcaoUsuario)
                    {
                        case "1":
                            ListarFilmes();
                            break;
                        case "2":
                            InserirFilmes();
                            break;
                        case "3":
                            AtualizarFilmes();
                            break;
                        case "4":
                            ExcluirFilmes();
                            break;
                        case "5":
                            VisualizarFilmes();
                            break;
                        case "C":
                            Console.Clear();
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();

                    }

                    opcaoUsuario = ObterOpcaoUsuario();
                }


                static void ListarFilmes()
                {
                    WriteLine("Listar filmes");

                    var lista = filmeRepositorio.Lista();//a variavel 'lista' recebera o conteudo da varavel repositorio do metodo Lista 

                    if (lista.Count == 0)//se o tamanho da lista for = a zero
                    {
                        WriteLine("Nenhuma filme cadastrado");
                        return;// para sair do metodo
                    }
                    foreach (var filme in lista)
                    {
                        var excluido = filme.retornaExcluido();//ira pegar o valor F/V pois é booleano
                        WriteLine("#ID {0}: - {1} {2}", filme.retornaId(), filme.retornaTitulo(), (excluido ? "*Excuildo*" : ""));
                        //est arranjo (excluido ? "*Excuildo*" : "") server para verifa se é F/V
                    }
                }

                static void InserirFilmes()//melhoreia criar um metodo que posssa economizar linhas
                {//e assi usar em AtualizarLista tambem
                    foreach (int i in Enum.GetValues(typeof(Genero)))//ira fazer uma varredura na lista de generos que enumeramos com o Enum
                    {//se um novo genero foi add, este codigo não se altera
                        WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));//imprimirar o nome e o numore correspondente
                    }

                    WriteLine("Digite o gênero entre as oções acima: ");//entrada
                    int entradaGenero = int.Parse(ReadLine());//capitura

                    WriteLine("Digite o titulo da série: ");
                    string entradaTitulo = ReadLine();

                    WriteLine("Digite o ano de lançamento da série: ");
                    int entradaAno = int.Parse(ReadLine());

                    WriteLine("Digite a descrição da série: ");
                    string entradaDescricao = ReadLine();

                    WriteLine("Digite duração do filme: ");
                    float entradaDuração = float.Parse(ReadLine());

                    Filme novoFilme = new Filme(id: filmeRepositorio.ProximoId(),//esta condição ira criar um id para cada criação nova
                                  genero: (Genero)entradaGenero,//insere o conteudo capturado no parametro.*em especial o (Genero) pq ele esta apontando o unum
                                  titulo: entradaTitulo,
                                  ano: entradaAno,
                                  descricao: entradaDescricao,
                                  duracao: entradaDuração);
                    filmeRepositorio.Insere(novoFilme);//insere os dados coletados no repositorio                                      
                }
                static async void AtualizarFilmes()
                {
                    WriteLine("Digite o id do filme: ");
                    int indiceFilme = int.Parse(ReadLine());

                    foreach (int i in Enum.GetValues(typeof(Genero)))
                    {
                        WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
                    }
                    WriteLine("Digite o genero entre as opções acima: ");
                    int entradaGenero = int.Parse(ReadLine());

                    WriteLine("Digite o titulo da série: ");
                    string entradaTitulo = ReadLine();

                    WriteLine("Digite ano de inicio da série: ");
                    int entradaAno = int.Parse(ReadLine());

                    WriteLine("Digite a descrição da série: ");
                    string entradaDescricao = ReadLine();

                    WriteLine("Digite duração do filme: ");
                    float entradaDuracao = float.Parse(ReadLine());

                    Filme atualizFilme = new Filme(id: indiceFilme,//pegamos o propio id que o usuario digitou
                                          genero: (Genero)entradaGenero,
                                          titulo: entradaTitulo,
                                          ano: entradaAno,
                                          descricao: entradaDescricao,
                                          duracao: entradaDuracao);

                    filmeRepositorio.Atualiza(indiceFilme, atualizFilme);//sobrescreve                                           
                }
                static void ExcluirFilmes()
                {
                    WriteLine("Digite o id do filme: ");
                    int indiceFilme = int.Parse(ReadLine());
                    //melhoria confirmar com o usuario se realmente deseja excluir
                    filmeRepositorio.Exclui(indiceFilme);
                }
                static void VisualizarFilmes()
                {
                    WriteLine("Digite o id do filme:");
                    int indiceFilme = int.Parse(ReadLine());

                    var filme = filmeRepositorio.RetornaPortaId(indiceFilme);//variavel do repositorio>metodo>valor
                    WriteLine(filme);//retornará o id inserido e ira consolidar com as infomações do metodo 'ToString()'
                }


                static string ObterOpcaoUsuario()
                {
                    WriteLine();
                    WriteLine("JR Filmes a seu dispo!!!");
                    WriteLine("Informe a opção desejada");

                    WriteLine("1- Listar filmes");
                    WriteLine("2- Inserir novo filme");
                    WriteLine("3- Atualizar filmes");
                    WriteLine("4- Excluir séries");
                    WriteLine("5- Visualizar séries");
                    WriteLine("C- Limpar tela");
                    WriteLine("X- Sair");
                    WriteLine();

                    string opcaoUsuario = ReadLine().ToUpper();//indiferente do tipo A ou a
                    WriteLine();
                    return opcaoUsuario;
                }

            }
        }
    }
}

