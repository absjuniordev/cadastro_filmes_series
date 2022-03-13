namespace dio.SERIES
{
    public abstract class EntidadeBase//
    {
        // Atributos
        public int Id { get; protected set; }
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public float Duracao { get; set; }
        public bool Excluido { get; set; } //para logica de exclusão

    }


}