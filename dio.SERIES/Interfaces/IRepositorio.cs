using System.Collections.Generic;
namespace dio.SERIES.Interfaces
{
    public interface IRepositorio<T>//Quem implementar ira poder passar esse tipo generico
    //DETERMINA QUE SE TENHA OS METODOS PARA O USO. GARANTE QUE AS CLASSES Q A IMPLMENTE TENHAM ESSES METODOS 
    {
         List<T> Lista();//Um metodo que se chama Lista e retorna uma lista de T. Ira substituir o T pela classe implementada (Serie)
         //e tranformar em lista
         T RetornaPortaId(int id);//passa um Id por parametro e retorna um T
         void Insere(T entidade);
         void Exclui(int id);
         void Atualiza(int id, T entidade);
         int ProximoId();
    }
}