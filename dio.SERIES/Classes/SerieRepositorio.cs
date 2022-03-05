using System;
using System.Collections.Generic;
using dio.SERIES.Interfaces;//para poder organizar

namespace dio.SERIES 
// Repositorio para organização do codigo
{
    public class SerieRepositorio : IRepositorio<Serie>// Nesta classe iremor implementa a interface IRepositorio a Serie 
    {//
        private List<Serie> listaSerie = new List<Serie>();// criada a lista nesta classe para organizar
        public void Atualiza(int id, Serie objeto)//onde era o 'T' agora é 'Serie'
        {
            listaSerie[id] = objeto;// Ira receber o objeto inserido e colocar em uma posição do vetor
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();//condição segura para exclusã
            //podemos implementat envio de email ao excluir

        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);//somente ira adcionar um objeto
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;//retorna a quantidade(Count sempre +1)
        }

        public Serie RetornaPortaId(int id)
        {
            return listaSerie[id];// retorna o que foi passado por um Id
        }
    }
}