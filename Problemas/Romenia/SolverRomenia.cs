using System;
using System.Collections.Generic;
using Base;
using IA.Algoritmos;
using IA.Problemas;
using IA.Problemas.Romenia;

namespace IA
{
    class SolverRomenia  : AbstractSolver<NomeCidadesEnum>, ISolver
    {

        private DictionaryList<NomeCidadesEnum, Estado<NomeCidadesEnum>> mapa;
        private Node<NomeCidadesEnum> inicio;
        private Node<NomeCidadesEnum> objetivo;
        
        public SolverRomenia()
        {
            mapa = new Mapa().GetMapa();
            inicio = new Node<NomeCidadesEnum>(new Estado<NomeCidadesEnum>(NomeCidadesEnum.NEAMT));
            objetivo = new  Node<NomeCidadesEnum>(new Estado<NomeCidadesEnum>(NomeCidadesEnum.BUCHAREST));

        }
        
        void ISolver.solve()
        {
            EscolherAlgoritmo(inicio,objetivo,mapa);
            Node<NomeCidadesEnum> resultado = algoritmoStrategy.solve();
            imprimirResultado(resultado);       
        }
    }
}