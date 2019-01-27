using System;

namespace IA.Problemas.Aspirador
{
    public class VariacaoLimpeza
    {
        public PosicaoEnum posicao;
        public Boolean esquerdaLimpa;
        public Boolean direitaLimpa;

        public VariacaoLimpeza(PosicaoEnum posicao, Boolean esquerdaLimpa,Boolean direitaLimpa)
        {
            this.posicao = posicao;
            this.esquerdaLimpa = esquerdaLimpa;
            this.direitaLimpa = direitaLimpa;
        }

        public bool Equals(VariacaoLimpeza variacaoLimpeza)
        {
            return variacaoLimpeza.direitaLimpa.Equals(direitaLimpa)
                && variacaoLimpeza.esquerdaLimpa.Equals(esquerdaLimpa)
                && variacaoLimpeza.posicao.Equals(posicao);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as VariacaoLimpeza);
        }

        public override string ToString()
        {
            var direita = direitaLimpa ? "direita limpa" : "direita suja";
            var esquerda = esquerdaLimpa ? "esquerda limpa" : "esquerda suja";
            return posicao + "|" + direita + "|" + esquerda;
        }

        public override int GetHashCode()
        {
            return posicao.GetHashCode() ^ direitaLimpa.GetHashCode() ^ esquerdaLimpa.GetHashCode();
        }
    }
}