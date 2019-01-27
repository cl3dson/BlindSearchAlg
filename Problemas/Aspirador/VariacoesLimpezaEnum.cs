namespace IA.Problemas.Aspirador
{
    
    //Nome dos enums está no seguinte padrão estadoNaEsquerda_localizacaoDoAspirador_estadoNaDireita
    public enum VariacoesLimpezaEnum
    {
        SUJO_ESQUERDA_SUJO,
        SUJO_DIREITA_SUJO,
        LIMPO_ESQUERDA_SUJO,
        LIMPO_DIREITA_SUJO,
        SUJO_ESQUERDA_LIMPO,
        SUJO_DIREITA_LIMPO,
        LIMPO_ESQUERDA_LIMPO,
        LIMPO_DIREITA_LIMPO
    }
}