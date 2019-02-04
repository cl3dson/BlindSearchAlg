using System.Collections.Generic;
using System.Linq;

namespace Base
{
    public class FuncaoSucessoraVisitados<T>
    {
        public static List<Estado<T>> getSucessores(Estado<T> estado,DictionaryList<T,Estado<T>> tabela,List<Estado<T>> visitados)
        {
            T valorEstado = estado.valor;
            List<Estado<T>> borda;
            tabela.TryGetValue(valorEstado, out borda);
            return borda.Where( x => !visitados.Contains(x)).ToList();
        }
    }
}