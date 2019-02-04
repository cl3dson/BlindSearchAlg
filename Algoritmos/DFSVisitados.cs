using System;
using System.Collections.Generic;
using System.Linq;
using Base;

namespace IA.Algoritmos
{
    public class DFSVisitados<T> : AbstractAlgoritmo<T>
    {
        public DFSVisitados(Node<T> inicio, Node<T> objetivo, DictionaryList<T, Estado<T>> mapa):
            base(inicio,objetivo,mapa)
        {
            
        }
        public override Node<T> solve()
        {
            List<Estado<T>> visitados = new List<Estado<T>>();
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
                List<Node<T>> sucessores = FuncaoSucessoraVisitados<T>.getSucessores(pai,mapa,visitados);
                visitados.Add(pai.estado);
                
                if (sucessores != null)
                {
                    foreach (Node<T> sucessor in sucessores)
                    {
                        borda.Push(sucessor);   
                    }
                }
            }
            
            throw new SemSolucaoException();
            
        }
    }
}