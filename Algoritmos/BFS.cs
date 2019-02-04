using System;
using System.Collections.Generic;
using Base;

namespace IA.Algoritmos
{
    public class BFS<T> : AbstractAlgoritmo<T>
    {

        public BFS(Node<T> inicio, Node<T> objetivo, DictionaryList<T, Estado<T>> mapa):
            base(inicio,objetivo,mapa)
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
                List<Estado<T>> sucessores = FuncaoSucessora<T>.getSucessores(pai.estado,mapa);
                
                if (sucessores != null)
                {
                    foreach (Estado<T> value in sucessores)
                    {
                        Node<T> noFilho = new Node<T>(value,pai);
                        borda.Enqueue(noFilho);
                    }
                }
            }
            
            throw new Exception("Nao há solucao");
        }
    }
}