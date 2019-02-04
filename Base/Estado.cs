using System;

namespace Base
{
    public class Estado <T> : IEquatable<Estado<T>>
    {
        public T valor;

        public Estado(T valor)
        {
            this.valor = valor;
        }

        public bool Equals(Estado<T> other)
        {
            return valor.Equals(other.valor);
        }
        
    }
}