using Base;

namespace IA.Algoritmos
{
    public interface IAlgoritmo<T>
    {
        Node<T> solve();
    }
}