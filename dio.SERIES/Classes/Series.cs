namespace dio.SERIES
{
    public class Serie : EntidadeBase//her da EntidadeBase
    {
        // Atributos
        private Genero Genero  {get; set;}
        private string Titulo { get; set; }
        private string Descricao {get; set;}
        private int Ano {get; set;}
        private bool Excluido {get;set;} //para logica de exclusão

        // Metodos(Construtor)

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)//
        {
            this.Id = id;//herdado da entidado base..
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false; //iniciaremos false p/ que de inicio não haja exclusão
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }
            // Sera usado para listagem
        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public void Excluir(){
            this.Excluido = true;// vira a ser verdadeiro queno for chamdo
        }
    }
    
}