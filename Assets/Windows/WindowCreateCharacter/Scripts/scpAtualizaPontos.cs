using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scpAtualizaPontos : MonoBehaviour
{
    public Text TextPontosHabilidade;
    public Text TextPontosCorpoCorpo;
    public Text TextPontosDistancia;
    public Text TextPontosAtletismo;
    public Text TextSneakPoints;

    void Start()
    {
        StaticPontos.metSetPontosIniciais();
    }

    void FixedUpdate()
    {
        TextPontosHabilidade.text = StaticPontos.plSkillPoints.ToString();
        TextPontosCorpoCorpo.text = StaticPontos.plMelee.ToString();
        TextPontosDistancia.text = StaticPontos.plRange.ToString();
        TextPontosAtletismo.text = StaticPontos.plAthletics.ToString();
        TextSneakPoints.text = StaticPontos.plSneak.ToString();
    }
}
