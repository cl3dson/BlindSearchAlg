using System;
using System.Collections.Generic;
using Base;
using IA.Algoritmos;

namespace IA.Problemas
{
    public abstract class AbstractSolver<T>
    {
        protected AbstractAlgoritmo<T> algoritmoStrategy;

        protected void EscolherAlgoritmo(Node<T> inicio, Node<T> objetivo, DictionaryList<T, Estado<T>> mapa)
        {
            Console.Clear();
            String problem;
            Console.WriteLine("escolha um algorimto:");
            Console.WriteLine("1 ------------------- BFS");
            Console.WriteLine("2 ------------------- DFS");
            Console.WriteLine("3 ------------------- DFS com visitados");
            problem = Console.ReadLine();
            Console.Clear();
            
            switch (problem)
            {
                case "1":
                    algoritmoStrategy = new BFS<T>(inicio,objetivo,mapa);
                    break;
                case "2":
                    algoritmoStrategy = new DFS<T>(inicio,objetivo,mapa);
                    break;
                case "3":
                    algoritmoStrategy = new DFSVisitados<T>(inicio,objetivo,mapa);
                    break;
                case "4":
                    algoritmoStrategy = new DFSLimitado<T>(inicio,objetivo,mapa);
                    break;
            }
        }

        protected void imprimirResultado(Node<T> resultado)
        {
            Stack<Node<T>> caminho = new Stack<Node<T>>();    
            
            caminho.Push(resultado);

            while (resultado.pai != null)
            {
                caminho.Push(resultado.pai);
                resultado = resultado.pai;
            }

            foreach (Node<T> cidade in caminho)
            {
                if(cidade.pai == null)
                    Console.Write(cidade.estado.valor);
                else
                    Console.Write(" ---> {0}",cidade.estado.valor);
            }
        }
    }
}