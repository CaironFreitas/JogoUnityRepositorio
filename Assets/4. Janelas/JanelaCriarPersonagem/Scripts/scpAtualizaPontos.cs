using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scpAtualizaPontos : MonoBehaviour
{
    public Text TextPontosHabilidade;
    public Text TextPontosCorpoCorpo;
    public Text TextPontosDistancia;
    public Text TextPontosResistencia;

    void Start()
    {
        StaticPontos.metSetPontosIniciais();
    }

    void FixedUpdate()
    {
        TextPontosHabilidade.text = StaticPontos.llPontosHabilidade.ToString();
        TextPontosCorpoCorpo.text = StaticPontos.llPontosCorpoCorpo.ToString();
        TextPontosDistancia.text = StaticPontos.llPontosDistancia.ToString();
        TextPontosResistencia.text = StaticPontos.llPontosResistencia.ToString();
    }
}
