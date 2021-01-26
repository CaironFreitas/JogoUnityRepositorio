using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class StaticPontos
{
    public static long llPontosHabilidadeInicial = 14;
    public static long llPontosHabilidade;
    public static long llPontosCorpoCorpo;
    public static long llPontosDistancia;
    public static long llPontosResistencia;

    public static void metSetPontosIniciais()
    {
        llPontosHabilidade = llPontosHabilidadeInicial;
        llPontosCorpoCorpo = 1;
        llPontosDistancia = 1;
        llPontosResistencia = 1;
    }

}
