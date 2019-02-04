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
        private DictionaryDictionary<NomeCidadesEnum, NomeCidadesEnum, int> distancias;
        private DictionaryDictionary<NomeCidadesEnum, NomeCidadesEnum, int> distanciasLinhaReta;

        
        public SolverRomenia()
        {
            mapa = new Mapa().GetMapa();
            distancias = new Mapa().GetDistancias();
            distanciasLinhaReta = new Mapa().GetDistanciasLinhaReta();
            inicio = new Node<NomeCidadesEnum>(new Estado<NomeCidadesEnum>(NomeCidadesEnum.ORADEIA));
            objetivo = new  Node<NomeCidadesEnum>(new Estado<NomeCidadesEnum>(NomeCidadesEnum.BUCHAREST));
        }
        
        void ISolver.solve()
        {
            EscolherAlgoritmo(inicio,objetivo,mapa,distancias,distanciasLinhaReta);
            Node<NomeCidadesEnum> resultado = algoritmoStrategy.solve();
            imprimirResultado(resultado);       
        }
    }
}