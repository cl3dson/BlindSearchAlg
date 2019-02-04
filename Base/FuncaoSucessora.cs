using System.Collections.Generic;

namespace Base
{
    public class FuncaoSucessora<T>
    {
        public static List<Node<T>> getSucessores(Node<T> node,DictionaryList<T,Estado<T>> tabela, Dictionary<T,Dictionary<T,int>> distancias)
        {
            T valorEstado = node.estado.valor;
            List<Estado<T>> estados;
            List<Node<T>> nodes = new List<Node<T>>();
            tabela.TryGetValue(valorEstado, out estados);
                        
            foreach (Estado<T> estado in estados)
            {
                if (distancias != null)
                {
                    Dictionary<T,int> valoresDistancias = distancias.GetValueOrDefault(valorEstado,new Dictionary<T, int>());
                    int custo = valoresDistancias.GetValueOrDefault(estado.valor, 0);
                    Node<T> noFilho = new Node<T>(estado,node,custo);
                    nodes.Add(noFilho);
                }
                else
                {
                    Node<T> noFilho = new Node<T>(estado,node);
                    nodes.Add(noFilho);
                }
            }

            return nodes;
        }
        
    }
}