using System;
using System.Collections.Generic;
using Base;
using IA.Problemas.Romenia;

namespace IA.Algoritmos
{
    public class BuscaGulosa<T> : AbstractAlgoritmo<T>
    {

        private Dictionary<T, Dictionary<T, int>> distanciasLinhaReta;
        
        public BuscaGulosa(Node<T> inicio, Node<T> objetivo, DictionaryList<T, Estado<T>> mapa,Dictionary<T, Dictionary<T, int>> distanciasLinhaReta) :
            base(inicio, objetivo, mapa)
        {
            this.distanciasLinhaReta = distanciasLinhaReta;
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

                List<Node<T>> sucessores = FuncaoSucessora<T>.getSucessores(pai, mapa, distancias);
                sucessores = ordernarPorDistanciaEmLinhaRetaAteObjetivo(sucessores, distanciasLinhaReta);
                 
                if (sucessores != null)
                {
                    Stack<Node<T>> pilhaTemp = new Stack<Node<T>>();
                    foreach (Node<T> sucessor in sucessores)
                    {
                        pilhaTemp.Push(sucessor);
                    }
                    
                    while (pilhaTemp.Count != 0) {
                        borda.Push(pilhaTemp.Pop());
                    }
                } 
            }

            throw new SemSolucaoException();
        }


        private List<Node<T>> ordernarPorDistanciaEmLinhaRetaAteObjetivo(List<Node<T>> sucessores,
            Dictionary<T, Dictionary<T, int>> distanciasLinhaReta)
        {
            sucessores.Sort((x, y) => distanciaLinhaRetaAteObjectivo(objetivo,x,distanciasLinhaReta).CompareTo(distanciaLinhaRetaAteObjectivo(objetivo,y,distanciasLinhaReta)));
            return sucessores;
        }

        private int distanciaLinhaRetaAteObjectivo(Node<T> objectivo, Node<T> noAtual,
            Dictionary<T, Dictionary<T, int>> distanciasLinhaReta)
        {
            Dictionary<T, int> distanciasAteObjetivo;
            distanciasLinhaReta.TryGetValue(objectivo.estado.valor, out distanciasAteObjetivo);

            int distancia;
            distanciasAteObjetivo.TryGetValue(noAtual.estado.valor, out distancia);

            return distancia;
        }
    }
}