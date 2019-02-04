using System.Collections.Generic;
using Base;

namespace IA.Algoritmos
{
    public abstract class AbstractAlgoritmo <T> : IAlgoritmo<T>
    {
        protected Node<T> inicio;
        protected Node<T> objetivo;
        protected DictionaryList<T, Estado<T>> mapa;
        protected Dictionary<T, Dictionary<T, int>> distancias;
        
        public AbstractAlgoritmo(Node<T> inicio, Node<T> objetivo, DictionaryList<T, Estado<T>> mapa,Dictionary<T,Dictionary<T,int>> distancias = null)
        {
            this.inicio = inicio;
            this.objetivo = objetivo;
            this.mapa = mapa;
            this.distancias = distancias;
        }

        public abstract Node<T> solve();
        
    }
}