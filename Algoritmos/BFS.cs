using System;
using System.Collections.Generic;
using Base;

namespace IA.Algoritmos
{
    public class BFS<T>
    {
        public static Node<T> solver(Node<T> inicio, Node<T> fim, DictionaryList<T,Estado<T>> mapa)
        {
            Queue<Node<T>> borda = new Queue<Node<T>>();
            borda.Enqueue(inicio);

            while (borda.Count != 0)
            {
                Node<T> pai = borda.Dequeue();
                if (pai.estado.valor.Equals(fim.estado.valor))
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