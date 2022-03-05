namespace dio.SERIES
{
    public abstract class EntidadeBase//criado para criação do Id de forma abstrata para que as demais possam herdar dela
    // e referencia a identificação
    {
        public int Id { get; protected set; }
    }
}