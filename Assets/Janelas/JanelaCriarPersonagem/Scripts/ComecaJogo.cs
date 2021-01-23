using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComecaJogo : MonoBehaviour
{
    public void IniciaJogo()
    {
        StaticPersonagem.llPontosHabilidade = StaticPontos.llPontosHabilidade;
        StaticPersonagem.llPontosCorpoCorpo = StaticPontos.llPontosCorpoCorpo;
        StaticPersonagem.llPontosDistancia = StaticPontos.llPontosDistancia;
        StaticPersonagem.llPontosResistencia = StaticPontos.llPontosResistencia;

        SceneManager.LoadScene("Gameplay");
    }
}
