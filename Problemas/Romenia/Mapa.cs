using System.Collections.Generic;
using Base;

namespace IA.Problemas.Romenia
{
    public class Mapa
    {
        public DictionaryList<NomeCidadesEnum,Estado<NomeCidadesEnum>> mapa;

        public Mapa()
        {
            mapa = new DictionaryList<NomeCidadesEnum,Estado<NomeCidadesEnum>>();
            
            mapa.Add(NomeCidadesEnum.ORADEIA,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.ORADEIA].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.ORADEIA));
            mapa[NomeCidadesEnum.ORADEIA].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.SIBIU));
            
            mapa.Add(NomeCidadesEnum.ZERIND,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.ORADEIA].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.ORADEIA));
            mapa[NomeCidadesEnum.ORADEIA].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.ARAD));
            
            mapa.Add(NomeCidadesEnum.ARAD,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.ARAD].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.ZERIND));
            mapa[NomeCidadesEnum.ARAD].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.SIBIU));
            mapa[NomeCidadesEnum.ARAD].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.TIMISOARA));

            
            mapa.Add(NomeCidadesEnum.TIMISOARA,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.TIMISOARA].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.ARAD));
            mapa[NomeCidadesEnum.TIMISOARA].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.LUGOJ));
            
            
            mapa.Add(NomeCidadesEnum.LUGOJ,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.LUGOJ].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.TIMISOARA));
            mapa[NomeCidadesEnum.LUGOJ].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.MEHADIA));
            
            mapa.Add(NomeCidadesEnum.MEHADIA,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.MEHADIA].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.LUGOJ));
            mapa[NomeCidadesEnum.MEHADIA].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.DOBRETA));
            
            
            mapa.Add(NomeCidadesEnum.DOBRETA,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.DOBRETA].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.MEHADIA));
            mapa[NomeCidadesEnum.DOBRETA].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.CRAIOVA));
            
            mapa.Add(NomeCidadesEnum.CRAIOVA,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.CRAIOVA].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.DOBRETA));
            mapa[NomeCidadesEnum.CRAIOVA].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.RIMNICU_VILCEA));
            mapa[NomeCidadesEnum.CRAIOVA].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.PITESTI));
            
            mapa.Add(NomeCidadesEnum.RIMNICU_VILCEA,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.RIMNICU_VILCEA].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.SIBIU));
            mapa[NomeCidadesEnum.RIMNICU_VILCEA].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.PITESTI));
            mapa[NomeCidadesEnum.RIMNICU_VILCEA].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.CRAIOVA));
            
            mapa.Add(NomeCidadesEnum.SIBIU,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.SIBIU].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.ORADEIA));
            mapa[NomeCidadesEnum.SIBIU].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.ARAD));
            mapa[NomeCidadesEnum.SIBIU].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.FAGARAS));
            mapa[NomeCidadesEnum.SIBIU].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.RIMNICU_VILCEA));
            
            mapa.Add(NomeCidadesEnum.FAGARAS,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.FAGARAS].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.SIBIU));
            mapa[NomeCidadesEnum.FAGARAS].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.BUCHAREST));
            
            mapa.Add(NomeCidadesEnum.PITESTI,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.PITESTI].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.RIMNICU_VILCEA));
            mapa[NomeCidadesEnum.PITESTI].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.CRAIOVA));
            mapa[NomeCidadesEnum.PITESTI].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.BUCHAREST));
            
            mapa.Add(NomeCidadesEnum.BUCHAREST,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.BUCHAREST].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.FAGARAS));
            mapa[NomeCidadesEnum.BUCHAREST].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.PITESTI));
            mapa[NomeCidadesEnum.BUCHAREST].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.GIURGIU));
            mapa[NomeCidadesEnum.BUCHAREST].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.URZICENI));
            
            mapa.Add(NomeCidadesEnum.GIURGIU,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.GIURGIU].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.BUCHAREST)); 
            
            mapa.Add(NomeCidadesEnum.URZICENI,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.URZICENI].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.BUCHAREST));
            mapa[NomeCidadesEnum.URZICENI].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.VASLUI));
            mapa[NomeCidadesEnum.URZICENI].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.HIRSOVA));
            
            mapa.Add(NomeCidadesEnum.HIRSOVA,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.HIRSOVA].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.URZICENI));
            mapa[NomeCidadesEnum.HIRSOVA].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.EFORIE));    
            
            mapa.Add(NomeCidadesEnum.EFORIE,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.EFORIE].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.HIRSOVA));    
            
            mapa.Add(NomeCidadesEnum.VASLUI,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.VASLUI].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.URZICENI));
            mapa[NomeCidadesEnum.VASLUI].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.IASL));  
            
            mapa.Add(NomeCidadesEnum.IASL,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.IASL].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.VASLUI));
            mapa[NomeCidadesEnum.IASL].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.NEAMT));  
            
            mapa.Add(NomeCidadesEnum.NEAMT,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.NEAMT].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.IASL));
            
        }

        public DictionaryList<NomeCidadesEnum, Estado<NomeCidadesEnum>> GetMapa()
        {
            return mapa;
        }
    }
}