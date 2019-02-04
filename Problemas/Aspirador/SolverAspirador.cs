using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Base;
using IA.Algoritmos;

namespace IA.Problemas.Aspirador
{
    public class SolverAspirador : AbstractSolver<VariacaoLimpeza>, ISolver
    {

        private DictionaryList<VariacaoLimpeza, Estado<VariacaoLimpeza>> mapa;
        private Node<VariacaoLimpeza> inicio;
        private Node<VariacaoLimpeza> objetivo;

        public SolverAspirador()
        {
            mapa = new Mapa().getMapa();
            inicio = new Node<VariacaoLimpeza>(
                new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.ESQUERDA, false, false)));
            objetivo = new Node<VariacaoLimpeza>(
                new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.ESQUERDA, true, true)));
        }


        void ISolver.solve()
        {
            EscolherAlgoritmo(inicio, objetivo, mapa);
            Node<VariacaoLimpeza> resultado = algoritmoStrategy.solve();
            imprimirResultado(resultado);
        }
    }
}