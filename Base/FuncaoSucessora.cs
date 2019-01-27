using System.Collections.Generic;

namespace Base
{
    public class FuncaoSucessora<T>
    {
        public static List<Estado<T>> getSucessores(Estado<T> estado,DictionaryList<T,Estado<T>> tabela)
        {
            T valorEstado = estado.valor;
            List<Estado<T>> borda;
            tabela.TryGetValue(valorEstado, out borda);
            return borda;
        }
    }
}