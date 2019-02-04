using Base;

namespace IA.Algoritmos
{
    public abstract class AbstractAlgoritmo <T> : IAlgoritmo<T>
    {
        protected Node<T> inicio;
        protected Node<T> objetivo;
        protected DictionaryList<T, Estado<T>> mapa;
        
        public AbstractAlgoritmo(Node<T> inicio, Node<T> objetivo, DictionaryList<T, Estado<T>> mapa)
        {
            this.inicio = inicio;
            this.objetivo = objetivo;
            this.mapa = mapa;
        }

        public abstract Node<T> solve();
        
    }
}