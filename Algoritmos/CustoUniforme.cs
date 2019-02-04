using System;
using System.Collections.Generic;
using Base;

namespace IA.Algoritmos
{
    public class CustoUniforme<T> : AbstractAlgoritmo<T>
    {

        public CustoUniforme(Node<T> inicio, Node<T> objetivo, DictionaryList<T, Estado<T>> mapa,Dictionary<T,Dictionary<T,int>> distancias):
            base(inicio,objetivo,mapa,distancias)
        {
            
        }
        
       public override Node<T> solve()
        {
            Queue<Node<T>> borda = new Queue<Node<T>>();
            borda.Enqueue(inicio);

            while (borda.Count != 0)
            {
                Node<T> pai = borda.Dequeue();
                if (pai.estado.Equals(objetivo.estado))
                {
                    Console.WriteLine("Objetivo alcançado");
                    return pai;
                }
                List<Node<T>> sucessores = FuncaoSucessora<T>.getSucessores(pai,mapa,distancias);
                sucessores = ordenarPorCusto(sucessores);
                
                if (sucessores != null)
                {
                    foreach (Node<T> sucessor in sucessores)
                    {
                        borda.Enqueue(sucessor);
                    }
                }
            }
            
            throw new SemSolucaoException();
        }

       private List<Node<T>> ordenarPorCusto(List<Node<T>> sucessores)
       {
           sucessores.Sort((x,y) => x.custoAteRaiz().CompareTo(y.custoAteRaiz()));
           return sucessores;
       }
    }
}