using static System.Console;

namespace dio.SERIES
{
    public class OpcoesDoUsuario
    {
        public static string Apresentacao()
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

        public static string ObterOpcaoUsuarioSerie()
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

       public static string ObterOpcaoUsuarioFilmes()
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