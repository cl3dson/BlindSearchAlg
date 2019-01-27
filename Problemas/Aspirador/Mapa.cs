using System.Collections.Generic;
using Base;

namespace IA.Problemas.Aspirador
{
    public class Mapa
    {
        public DictionaryList<VariacaoLimpeza,Estado<VariacaoLimpeza>> mapa;

        public Mapa()
        {
            mapa = new DictionaryList<VariacaoLimpeza,Estado<VariacaoLimpeza>>();

            VariacaoLimpeza dff = new VariacaoLimpeza(PosicaoEnum.DIREITA, false, false);
            mapa.Add(dff, new List<Estado<VariacaoLimpeza>>());
            mapa[dff].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.DIREITA,false,false)));
            mapa[dff].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.ESQUERDA,false,false)));
            mapa[dff].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.DIREITA,false,true)));

            VariacaoLimpeza eff = new VariacaoLimpeza(PosicaoEnum.ESQUERDA, false, false);
            mapa.Add(eff,new List<Estado<VariacaoLimpeza>>());
            mapa[eff].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.ESQUERDA,false,false)));
            mapa[eff].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.DIREITA,false,false)));
            mapa[eff].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.ESQUERDA,true,false)));
            
            VariacaoLimpeza etf = new VariacaoLimpeza(PosicaoEnum.ESQUERDA,true,false);
            mapa.Add(etf,new List<Estado<VariacaoLimpeza>>());    
            mapa[etf].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.ESQUERDA,true,false)));
            mapa[etf].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.ESQUERDA,true,false)));
            mapa[etf].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.DIREITA,true,false)));

            VariacaoLimpeza dtf = new VariacaoLimpeza(PosicaoEnum.DIREITA,true,false);
            mapa.Add(dtf,new List<Estado<VariacaoLimpeza>>());    
            mapa[dtf].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.DIREITA,true,false)));
            mapa[dtf].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.ESQUERDA,true,false)));
            mapa[dtf].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.DIREITA,true,true)));
            
            VariacaoLimpeza dft = new VariacaoLimpeza(PosicaoEnum.DIREITA,false,true);
            mapa.Add(dft,new List<Estado<VariacaoLimpeza>>());    
            mapa[dft].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.DIREITA,false,true)));
            mapa[dft].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.DIREITA,false,true)));
            mapa[dft].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.ESQUERDA,false,true)));

            VariacaoLimpeza eft = new VariacaoLimpeza(PosicaoEnum.ESQUERDA,false,true);
            mapa.Add(eft,new List<Estado<VariacaoLimpeza>>());    
            mapa[eft].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.ESQUERDA,false,true)));
            mapa[eft].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.DIREITA,false,true)));
            mapa[eft].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.ESQUERDA,true,true)));
            
            VariacaoLimpeza tet = new VariacaoLimpeza(PosicaoEnum.ESQUERDA,true,true);
            mapa.Add(tet,new List<Estado<VariacaoLimpeza>>());
            mapa[tet].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.ESQUERDA,true,true)));
            mapa[tet].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.ESQUERDA,true,true)));
            mapa[tet].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.DIREITA,true,true)));

            VariacaoLimpeza tdt = new VariacaoLimpeza(PosicaoEnum.DIREITA,true,true);
            mapa.Add(tdt,new List<Estado<VariacaoLimpeza>>());
            mapa[tdt].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.DIREITA,true,true)));
            mapa[tdt].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.DIREITA,true,true)));
            mapa[tdt].Add(new Estado<VariacaoLimpeza>(new VariacaoLimpeza(PosicaoEnum.ESQUERDA,true,true)));
        }

        public DictionaryList<VariacaoLimpeza,Estado<VariacaoLimpeza>> getMapa()
        {
            return this.mapa;
        }
    }
}