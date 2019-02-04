using System;
using System.Collections.Generic;
using Base;

namespace IA.Algoritmos
{
    public class DFSLimitado<T> : AbstractAlgoritmo<T>
    {
        
        public DFSLimitado(Node<T> inicio, Node<T> objetivo, DictionaryList<T, Estado<T>> mapa):
            base(inicio,objetivo,mapa)
        {
        }
        
        public override Node<T> solve()
        {
            Console.Clear();
            int profundidadeMaxima;
            Console.WriteLine("informe a profundidade maxima:");
            profundidadeMaxima = Int32.Parse(Console.ReadLine());
            Console.Clear();

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
                
                List<Estado<T>> sucessores = FuncaoSucessora<T>.getSucessores(pai.estado,mapa);
                
                if (getProfunidadeNode(pai) < profundidadeMaxima && sucessores != null)
                {
                    foreach (Estado<T> value in sucessores)
                    {
                        Node<T> noFilho = new Node<T>(value,pai);
                        borda.Push(noFilho);
                    }
                }
            }
            throw new Exception("Nao há solucao");
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