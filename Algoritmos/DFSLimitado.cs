using System;
using System.Collections.Generic;
using Base;

namespace IA.Algoritmos
{
    public class DFSLimitado<T> : AbstractAlgoritmo<T>
    {
     
        private int profundidadeMaxima;
        
        public DFSLimitado(Node<T> inicio, Node<T> objetivo, DictionaryList<T, Estado<T>> mapa,int profundidadeMaxima):
            base(inicio,objetivo,mapa)
        {
            this.profundidadeMaxima = profundidadeMaxima;
        }

        public void setProfundidadeMaxima(int numero)
        {
            profundidadeMaxima = numero;
        }

        public int getProfundidadeMaxima()
        {
            return profundidadeMaxima;
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
                
                if (getProfunidadeNode(pai) < profundidadeMaxima && sucessores != null)
                {
                    foreach (Node<T> sucessor in sucessores)
                    {
                        borda.Push(sucessor);
                    }
                }
            }
            throw new SemSolucaoException();
        }


        private int getProfunidadeNode(Node<T> node)
        {
            int profundidade = 0;
            while (node.pai != null)
            {
                profundidade++;
                node = node.pai;
            }

            return profundidade;
        }
    }
}