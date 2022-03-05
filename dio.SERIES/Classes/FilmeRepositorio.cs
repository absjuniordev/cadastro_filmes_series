using System;
using System.Collections.Generic;
using dio.SERIES.Interfaces;//para poder organizar

namespace dio.SERIES 
// Repositorio para organização do codigo
{
    public class FilmeRepositorio : IRepositorio<Filme>// Nesta classe iremor implementa a interface IRepositorio a Serie 
    {//
        private List<Filme> listaFilme = new List<Filme>();// criada a lista nesta classe para organizar
        public void Atualiza(int id, Filme objeto)//onde era o 'T' agora é 'Serie'
        {
            listaFilme[id] = objeto;// Ira receber o objeto inserido e colocar em uma posição do vetor
        }

        public void Exclui(int id)
        {
            listaFilme[id].Excluir();//condição segura para exclusã
            //podemos implementat envio de email ao excluir

        }

        public void Insere(Filme objeto)
        {
            listaFilme.Add(objeto);//somente ira adcionar um objeto
        }

        public List<Filme> Lista()
        {
            return listaFilme;
        }

        public int ProximoId()
        {
            return listaFilme.Count;//retorna a quantidade(Count sempre +1)
        }

        public Filme RetornaPortaId(int id)
        {
            return listaFilme[id];// retorna o que foi passado por um Id
        }
    }
}