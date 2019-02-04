using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Base;
using IA.Algoritmos;

namespace IA.Problemas.Aspirador
{
    public class SolverAspirador : ISolver
    {
        void ISolver.solve()
        {
            Console.Clear();
            DictionaryList<VariacaoLimpeza,Estado<VariacaoLimpeza>> mapa = new Mapa().getMapa();
            
            Node<VariacaoLimpeza> inicio =
                new Node<VariacaoLimpeza>(
                    new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.ESQUERDA, false, false)));
            
            Node<VariacaoLimpeza> fim =
                new Node<VariacaoLimpeza>(
                    new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.ESQUERDA, true, true)));

            
            Node<VariacaoLimpeza> resultado = DFS<VariacaoLimpeza>.solver(inicio, fim, mapa);
            
            Stack<Node<VariacaoLimpeza>> caminho = new Stack<Node<VariacaoLimpeza>>();    
            caminho.Push(resultado);

            while (resultado.pai != null)
            {
                caminho.Push(resultado.pai);
                resultado = resultado.pai;
            }

            foreach (Node<VariacaoLimpeza> cidade in caminho)
            {
                if (cidade.pai == null)
                    Console.Write(cidade.estado.valor);
                else
                    Console.Write(" ---> {0}", cidade.estado.valor);
            }
        }
    }
}