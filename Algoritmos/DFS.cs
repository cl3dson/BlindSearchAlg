using System;
using System.Collections.Generic;
using Base;

namespace IA.Algoritmos
{
    public class DFS<T> : AbstractAlgoritmo<T>
    {
        
        public DFS(Node<T> inicio, Node<T> objetivo, DictionaryList<T, Estado<T>> mapa):
            base(inicio,objetivo,mapa)
        {
            
        }
        
        public override Node<T> solve()
        {
            Stack<Node<T>> borda = new Stack<Node<T>>();
            borda.Push(inicio);
            
            while (borda.Count != 0)
            {
              
                Node<T> pai = borda.Pop();
                if (pai.estado.valor.Equals(objetivo.estado.valor))
                {
                    Console.WriteLine("Objetivo alcançado");
                    return pai;
                }
                List<Node<T>> sucessores = FuncaoSucessora<T>.getSucessores(pai,mapa,distancias);
                
                if (sucessores != null)
                {
                    Shuffle(sucessores);
                    foreach (Node<T> sucessor in sucessores)
                    {
                        borda.Push(sucessor);
                    }
                }
            }
            throw new SemSolucaoException();
        }
        

       private void Shuffle<T>(IList<T> list)  
        {  
            Random rng = new Random();  

            int n = list.Count;  
            while (n > 1) {  
                n--;  
                int k = rng.Next(n + 1);  
                T value = list[k];  
                list[k] = list[n];  
                list[n] = value;  
            }  
        }
    }
}