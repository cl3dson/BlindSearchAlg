using System.Collections.Generic;

namespace Base
{
    public class DictionaryList<K,T> : Dictionary<K,List<T>>
    {
        
    }
    
    public class DictionaryDictionary<K,T,L> : Dictionary<K,Dictionary<T,L>>
    {
        
    }
}