using System.Collections.Generic;
using System.Linq;

namespace Base
{
    public class FuncaoSucessoraVisitados<T>
    {
        public static List<Node<T>> getSucessores(Node<T> node,DictionaryList<T,Estado<T>> tabela,List<Estado<T>> visitados)
        {
            T valorEstado = node.estado.valor;
            List<Estado<T>> estados;
            List<Node<T>> nodes = new List<Node<T>>();
            tabela.TryGetValue(valorEstado, out estados);
            estados = estados.Where( x => !visitados.Contains(x)).ToList();
            
            foreach (Estado<T> value in estados)
            {
                Node<T> noFilho = new Node<T>(value,node);
                nodes.Add(noFilho);
            }

            return nodes;
            
        }
    }
}