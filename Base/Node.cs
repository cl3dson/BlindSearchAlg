namespace Base
{
    public class Node<T>
    {
        public int profundidade;
        public Estado<T> estado;
        public int custo;
        public Node<T> pai;

        public Node()
        {
            estado = null;
            pai = null;
        }
        
        public Node(Estado<T> estado)
        {
            this.estado = estado;
            profundidade = 0;
            custo = 0;
            pai = null;
        }

        public Node(Estado<T> estado, Node<T> pai)
        {
            this.estado = estado;
            this.pai = pai;
            if (pai == null)
                profundidade = 0;
            else
                profundidade = pai.profundidade++;
        }

        public Node(Estado<T> estado, Node<T> pai, int custo)
        {
            this.estado = estado;
            this.custo = custo;
            this.pai = pai;
            if (pai == null)
            {
                profundidade = 0;
                this.custo = 0;
            }
            else
                profundidade = pai.profundidade++;
        }

        public int custoAteRaiz()
        {
            int custo = 0;
            Node<T> paiAtual = this.pai;
            while (paiAtual != null)
            {
                custo += paiAtual.custo;
                paiAtual = paiAtual.pai;
            }

            return custo;
        }
        
        
    }
}