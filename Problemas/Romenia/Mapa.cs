using System.Collections.Generic;
using Base;

namespace IA.Problemas.Romenia
{
    public class Mapa
    {
        public DictionaryList<NomeCidadesEnum,Estado<NomeCidadesEnum>> mapa;
        public DictionaryDictionary<NomeCidadesEnum, NomeCidadesEnum, int> distancias;
        public DictionaryDictionary<NomeCidadesEnum, NomeCidadesEnum, int> distanciasLinhaReta;

        public Mapa()
        {
            mapa = new DictionaryList<NomeCidadesEnum,Estado<NomeCidadesEnum>>();
            
            mapa.Add(NomeCidadesEnum.ORADEIA,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.ORADEIA].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.ZERIND));
            mapa[NomeCidadesEnum.ORADEIA].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.SIBIU));
            
            mapa.Add(NomeCidadesEnum.ZERIND,new List<Estado<NomeCidadesEnum>>());
            mapa[NomeCidadesEnum.ZERIND].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.ORADEIA));
            mapa[NomeCidadesEnum.ZERIND].Add(new Estado<NomeCidadesEnum>(NomeCidadesEnum.ARAD));
            
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
            
            
            distancias = new DictionaryDictionary<NomeCidadesEnum,NomeCidadesEnum, int>();
            
            distancias.Add(NomeCidadesEnum.ORADEIA,new Dictionary<NomeCidadesEnum, int>());
            distancias[NomeCidadesEnum.ORADEIA].Add(NomeCidadesEnum.ZERIND,71);
            distancias[NomeCidadesEnum.ORADEIA].Add(NomeCidadesEnum.SIBIU,151);
            
            distancias.Add(NomeCidadesEnum.ZERIND,new Dictionary<NomeCidadesEnum, int>());
            distancias[NomeCidadesEnum.ZERIND].Add(NomeCidadesEnum.ORADEIA,71);
            distancias[NomeCidadesEnum.ZERIND].Add(NomeCidadesEnum.ARAD,75);
            
            distancias.Add(NomeCidadesEnum.ARAD,new Dictionary<NomeCidadesEnum, int>());
            distancias[NomeCidadesEnum.ARAD].Add(NomeCidadesEnum.ZERIND,75);
            distancias[NomeCidadesEnum.ARAD].Add(NomeCidadesEnum.SIBIU,140);
            distancias[NomeCidadesEnum.ARAD].Add(NomeCidadesEnum.TIMISOARA,118);
            
            distancias.Add(NomeCidadesEnum.TIMISOARA,new Dictionary<NomeCidadesEnum, int>());
            distancias[NomeCidadesEnum.TIMISOARA].Add(NomeCidadesEnum.ARAD,118);
            distancias[NomeCidadesEnum.TIMISOARA].Add(NomeCidadesEnum.LUGOJ,111);

            distancias.Add(NomeCidadesEnum.LUGOJ,new Dictionary<NomeCidadesEnum, int>());
            distancias[NomeCidadesEnum.LUGOJ].Add(NomeCidadesEnum.TIMISOARA,118);
            distancias[NomeCidadesEnum.LUGOJ].Add(NomeCidadesEnum.MEHADIA,70);
            
            distancias.Add(NomeCidadesEnum.MEHADIA,new Dictionary<NomeCidadesEnum, int>());
            distancias[NomeCidadesEnum.MEHADIA].Add(NomeCidadesEnum.LUGOJ,70);
            distancias[NomeCidadesEnum.MEHADIA].Add(NomeCidadesEnum.DOBRETA,75);
            
            distancias.Add(NomeCidadesEnum.DOBRETA,new Dictionary<NomeCidadesEnum, int>());
            distancias[NomeCidadesEnum.DOBRETA].Add(NomeCidadesEnum.MEHADIA,75);
            distancias[NomeCidadesEnum.DOBRETA].Add(NomeCidadesEnum.CRAIOVA,120);
            
            distancias.Add(NomeCidadesEnum.CRAIOVA,new Dictionary<NomeCidadesEnum, int>());
            distancias[NomeCidadesEnum.CRAIOVA].Add(NomeCidadesEnum.DOBRETA,120);
            distancias[NomeCidadesEnum.CRAIOVA].Add(NomeCidadesEnum.RIMNICU_VILCEA,146);
            distancias[NomeCidadesEnum.CRAIOVA].Add(NomeCidadesEnum.PITESTI,138);
            
            distancias.Add(NomeCidadesEnum.RIMNICU_VILCEA,new Dictionary<NomeCidadesEnum, int>());
            distancias[NomeCidadesEnum.RIMNICU_VILCEA].Add(NomeCidadesEnum.SIBIU,80);
            distancias[NomeCidadesEnum.RIMNICU_VILCEA].Add(NomeCidadesEnum.PITESTI,97);
            distancias[NomeCidadesEnum.RIMNICU_VILCEA].Add(NomeCidadesEnum.CRAIOVA,146)
                ;
            distancias.Add(NomeCidadesEnum.SIBIU,new Dictionary<NomeCidadesEnum, int>());
            distancias[NomeCidadesEnum.SIBIU].Add(NomeCidadesEnum.ORADEIA,151);
            distancias[NomeCidadesEnum.SIBIU].Add(NomeCidadesEnum.ARAD,140);
            distancias[NomeCidadesEnum.SIBIU].Add(NomeCidadesEnum.FAGARAS,99);
            distancias[NomeCidadesEnum.SIBIU].Add(NomeCidadesEnum.RIMNICU_VILCEA,80);
            
            distancias.Add(NomeCidadesEnum.FAGARAS,new Dictionary<NomeCidadesEnum, int>());
            distancias[NomeCidadesEnum.FAGARAS].Add(NomeCidadesEnum.SIBIU,99);
            distancias[NomeCidadesEnum.FAGARAS].Add(NomeCidadesEnum.BUCHAREST,211);
            
            distancias.Add(NomeCidadesEnum.PITESTI,new Dictionary<NomeCidadesEnum, int>());
            distancias[NomeCidadesEnum.PITESTI].Add(NomeCidadesEnum.RIMNICU_VILCEA,97);
            distancias[NomeCidadesEnum.PITESTI].Add(NomeCidadesEnum.CRAIOVA,138);
            distancias[NomeCidadesEnum.PITESTI].Add(NomeCidadesEnum.BUCHAREST,101);
            
            distancias.Add(NomeCidadesEnum.BUCHAREST,new Dictionary<NomeCidadesEnum, int>());
            distancias[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.FAGARAS,211);
            distancias[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.PITESTI,101);
            distancias[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.GIURGIU,90);
            distancias[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.URZICENI,85);
            
            distancias.Add(NomeCidadesEnum.GIURGIU,new Dictionary<NomeCidadesEnum, int>());
            distancias[NomeCidadesEnum.GIURGIU].Add(NomeCidadesEnum.BUCHAREST,90);
            
            distancias.Add(NomeCidadesEnum.URZICENI,new Dictionary<NomeCidadesEnum, int>());
            distancias[NomeCidadesEnum.URZICENI].Add(NomeCidadesEnum.BUCHAREST,85);
            distancias[NomeCidadesEnum.URZICENI].Add(NomeCidadesEnum.VASLUI,142);
            distancias[NomeCidadesEnum.URZICENI].Add(NomeCidadesEnum.HIRSOVA,98);
            
            distancias.Add(NomeCidadesEnum.HIRSOVA,new Dictionary<NomeCidadesEnum, int>());
            distancias[NomeCidadesEnum.HIRSOVA].Add(NomeCidadesEnum.URZICENI,98);
            distancias[NomeCidadesEnum.HIRSOVA].Add(NomeCidadesEnum.EFORIE,86);
            
            distancias.Add(NomeCidadesEnum.EFORIE,new Dictionary<NomeCidadesEnum, int>());
            distancias[NomeCidadesEnum.EFORIE].Add(NomeCidadesEnum.HIRSOVA,86);
            
            distancias.Add(NomeCidadesEnum.VASLUI,new Dictionary<NomeCidadesEnum, int>());
            distancias[NomeCidadesEnum.VASLUI].Add(NomeCidadesEnum.URZICENI,142);
            distancias[NomeCidadesEnum.VASLUI].Add(NomeCidadesEnum.IASL,92);
            
            distancias.Add(NomeCidadesEnum.IASL,new Dictionary<NomeCidadesEnum, int>());
            distancias[NomeCidadesEnum.IASL].Add(NomeCidadesEnum.VASLUI,92);
            distancias[NomeCidadesEnum.IASL].Add(NomeCidadesEnum.NEAMT,87);
            
            distancias.Add(NomeCidadesEnum.NEAMT,new Dictionary<NomeCidadesEnum, int>());
            distancias[NomeCidadesEnum.NEAMT].Add(NomeCidadesEnum.IASL,87);
            
            
            
            distanciasLinhaReta = new DictionaryDictionary<NomeCidadesEnum,NomeCidadesEnum, int>();
            distanciasLinhaReta.Add(NomeCidadesEnum.BUCHAREST,new Dictionary<NomeCidadesEnum, int>());
            distanciasLinhaReta[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.ARAD,366);
            distanciasLinhaReta[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.BUCHAREST,0);
            distanciasLinhaReta[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.CRAIOVA,160);
            distanciasLinhaReta[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.DOBRETA,242);
            distanciasLinhaReta[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.EFORIE,161);
            distanciasLinhaReta[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.FAGARAS,178);
            distanciasLinhaReta[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.GIURGIU,77);
            distanciasLinhaReta[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.HIRSOVA,151);
            distanciasLinhaReta[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.IASL,226);
            distanciasLinhaReta[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.LUGOJ,244);
            distanciasLinhaReta[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.MEHADIA,241);
            distanciasLinhaReta[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.NEAMT,234);
            distanciasLinhaReta[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.ORADEIA,380);
            distanciasLinhaReta[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.PITESTI,98);
            distanciasLinhaReta[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.RIMNICU_VILCEA,193);
            distanciasLinhaReta[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.SIBIU,253);
            distanciasLinhaReta[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.TIMISOARA,329);
            distanciasLinhaReta[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.URZICENI,80);
            distanciasLinhaReta[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.VASLUI,199);
            distanciasLinhaReta[NomeCidadesEnum.BUCHAREST].Add(NomeCidadesEnum.ZERIND,374);
           
        }

        public DictionaryList<NomeCidadesEnum, Estado<NomeCidadesEnum>> GetMapa()
        {
            return mapa;
        }

        public DictionaryDictionary<NomeCidadesEnum, NomeCidadesEnum, int> GetDistancias()
        {
            return distancias;
        }
        
        public DictionaryDictionary<NomeCidadesEnum, NomeCidadesEnum, int> GetDistanciasLinhaReta()
        {
            return distanciasLinhaReta;
        }
    }
}