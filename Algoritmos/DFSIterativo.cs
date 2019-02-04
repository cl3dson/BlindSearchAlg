using System;
using Base;

namespace IA.Algoritmos
{
    public class DFSIterativo<T> : AbstractAlgoritmo<T>
    {
        private DFSLimitado<T> algoritmoDFSLimitado;
        
        public DFSIterativo(Node<T> inicio, Node<T> objetivo, DictionaryList<T, Estado<T>> mapa):
            base(inicio,objetivo,mapa)
        {
            algoritmoDFSLimitado = new DFSLimitado<T>(inicio,objetivo,mapa,0);
        }
        
        public override Node<T> solve(){
            try
            {
                Console.WriteLine("tentando com profundidade máxima {0}",algoritmoDFSLimitado.getProfundidadeMaxima());
                return algoritmoDFSLimitado.solve();
            }
            catch(SemSolucaoException e)
            {
                algoritmoDFSLimitado.setProfundidadeMaxima(algoritmoDFSLimitado.getProfundidadeMaxima()+1);
                return solve();
            }
        }
    }
    
    
}