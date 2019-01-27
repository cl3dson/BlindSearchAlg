using System;
using System.Collections.Generic;
using Base;
using IA.Algoritmos;
using IA.Problemas.Romenia;

namespace IA
{
    class SolverRomenia
    {
        static void solve()
        {
            DictionaryList<NomeCidadesEnum,Estado<NomeCidadesEnum>> mapa = new Mapa().GetMapa();
            
            Node<NomeCidadesEnum> estadoInicial = new Node<NomeCidadesEnum>(new Estado<NomeCidadesEnum>(NomeCidadesEnum.NEAMT));
            Node<NomeCidadesEnum> estadoFinal= new  Node<NomeCidadesEnum>(new Estado<NomeCidadesEnum>(NomeCidadesEnum.BUCHAREST));

            Node<NomeCidadesEnum> resultado = DFS<NomeCidadesEnum>.solver(estadoInicial, estadoFinal, mapa);
            Stack<Node<NomeCidadesEnum>> caminho = new Stack<Node<NomeCidadesEnum>>();    
            caminho.Push(resultado);

            while (resultado.pai != null)
            {
                caminho.Push(resultado.pai);
                resultado = resultado.pai;
            }

            foreach (Node<NomeCidadesEnum> cidade in caminho)
            {
                if(cidade.pai == null)
                 Console.Write(cidade.estado.valor);
                else
                 Console.Write(" ---> {0}",cidade.estado.valor);
            }
        
        }
    }
}